
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace MecanicaForm
{
    public partial class HomePage : Form
    {
        private System.Windows.Forms.Timer menuTimer;
        private bool isMenuOpening;
        private int targetMenuWidth = 258;
        private int menuStep = 20;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public HomePage()
        {
            InitializeComponent();

            menuTimer = new System.Windows.Forms.Timer();
            menuTimer.Interval = 10;
            menuTimer.Tick += MenuTimer_Tick;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            leftMenu.Width = 0;
            leftMenu.Visible = false;

            CarregarDashboard();
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            if (menuTimer.Enabled) return;

            if (leftMenu.Visible && leftMenu.Width > 0)
            {
                isMenuOpening = false;
                menuTimer.Start();
            }
            else
            {
                leftMenu.Visible = true;
                isMenuOpening = true;
                menuTimer.Start();
            }
        }

        private void closeWindowBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuTimer_Tick(object? sender, EventArgs e)
        {
            if (isMenuOpening)
            {
                if (leftMenu.Width < targetMenuWidth)
                {
                    leftMenu.Width += menuStep;
                    if (leftMenu.Width >= targetMenuWidth)
                    {
                        leftMenu.Width = targetMenuWidth;
                        menuTimer.Stop();
                    }
                }
                else
                {
                    menuTimer.Stop();
                }
            }
            else
            {
                if (leftMenu.Width > 0)
                {
                    leftMenu.Width -= menuStep;
                    if (leftMenu.Width <= 0)
                    {
                        leftMenu.Width = 0;
                        leftMenu.Visible = false;
                        menuTimer.Stop();
                    }
                }
                else
                {
                    leftMenu.Visible = false;
                    menuTimer.Stop();
                }
            }
        }
        private void windowTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void inserirBtn_Click(object sender, EventArgs e)
        {
            var InserirForm = new InserirForm();
            InserirForm.Show();
            this.Hide();
        }

        private void excluirBtn_Click(object sender, EventArgs e)
        {
            var ExcluirForm = new ExcluirForm();
            ExcluirForm.Show();
            this.Hide();
        }

        private void alterarBtn_Click(object sender, EventArgs e)
        {
            var AlterarForm = new AlterarForm();
            AlterarForm.Show();
            this.Hide();
        }

        private void consultarBtn_Click(object sender, EventArgs e)
        {
            var ConsultarForm = new ConsultarForm();
            ConsultarForm.Show();
            this.Hide();
        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void proximoBtn_Click(object sender, EventArgs e)
        {
            var InserirForm = new InserirForm();
            InserirForm.Show();
            this.Hide();
        }

        private void anteriorBtn_Click(object sender, EventArgs e)
        {
            var ConsultarForm = new ConsultarForm();
            ConsultarForm.Show();
            this.Hide();
        }

        private void ultimoBtn_Click(object sender, EventArgs e)
        {
            var ConsultarForm = new ConsultarForm();
            ConsultarForm.Show();
            this.Hide();
        }

        private void CarregarDashboard()
        {
            try
            {
                using var conn = new MySqlConnection(DatabaseInitializer.AppConnectionString);
                conn.Open();
                // KPIs
                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT
                        COUNT(*) AS Total,
                        SUM(CASE WHEN Tipo='Peca' THEN 1 ELSE 0 END) AS Pecas,
                        SUM(CASE WHEN Tipo='Servico' THEN 1 ELSE 0 END) AS Servicos,
                        COALESCE(SUM(Valor),0) AS ValorTotal,
                        COALESCE(AVG(Valor),0) AS ValorMedio
                      FROM registros";
                    using var rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        int total = rd.IsDBNull(0) ? 0 : rd.GetInt32(0);
                        int pecas = rd.IsDBNull(1) ? 0 : Convert.ToInt32(rd.GetValue(1));
                        int servicos = rd.IsDBNull(2) ? 0 : Convert.ToInt32(rd.GetValue(2));
                        decimal valorTotal = rd.IsDBNull(3) ? 0 : Convert.ToDecimal(rd.GetValue(3));
                        decimal valorMedio = rd.IsDBNull(4) ? 0 : Convert.ToDecimal(rd.GetValue(4));

                        kpiTotalLabel.Text = $"Total de Registros: {total}";
                        kpiPecasLabel.Text = $"Total de Peças: {pecas}";
                        kpiServicosLabel.Text = $"Total de Serviços: {servicos}";
                        kpiTotalValorLabel.Text = $"Valor Total: {valorTotal.ToString("C", new CultureInfo("pt-BR"))}";
                        kpiValorMedioLabel.Text = $"Valor Médio: {valorMedio.ToString("C", new CultureInfo("pt-BR"))}";
                    }
                }

                // Recentes
                using (var cmd2 = conn.CreateCommand())
                {
                    cmd2.CommandText = "SELECT Id, Responsavel, Nome, Valor, Tipo, CriadoEm FROM registros ORDER BY CriadoEm DESC, Id DESC LIMIT 15";
                    using var da = new MySqlDataAdapter(cmd2);
                    var dt = new DataTable();
                    da.Fill(dt);
                    gridRecentes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dashboard: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
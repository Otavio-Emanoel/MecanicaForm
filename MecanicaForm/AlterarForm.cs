using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace MecanicaForm
{
    public partial class AlterarForm : Form
    {
        public AlterarForm()
        {

            InitializeComponent();

            menuTimer = new System.Windows.Forms.Timer();
            menuTimer.Interval = 10;
            menuTimer.Tick += MenuTimer_Tick;

            // Config inicial do form
            idTxt.Enabled = false; // Id é chave primária auto-inc
            insertBtn.Click += insertBtn_Click; // salvar
            dataGrid.SelectionChanged += dataGrid_SelectionChanged;
        }
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


        private void homePageBtn_Click(object sender, EventArgs e)
        {
            var HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
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

        private void primeiroBtn_Click(object sender, EventArgs e)
        {
            var HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }

        private void anteriorBtn_Click(object sender, EventArgs e)
        {
            var ExcluirForm = new ExcluirForm();
            ExcluirForm.Show();
            this.Hide();
        }

        private void proximoBtn_Click(object sender, EventArgs e)
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

        private void AlterarForm_Load(object sender, EventArgs e)
        {
            leftMenu.Width = 0;
            leftMenu.Visible = false;

            CarregarGrid();
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

        private void CarregarGrid()
        {
            try
            {
                using var conn = new MySqlConnection(DatabaseInitializer.AppConnectionString);
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Id, Responsavel, Nome, Valor, Detalhes, Tipo, CriadoEm FROM registros ORDER BY CriadoEm DESC, Id DESC";
                using var da = new MySqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dataGrid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar registros: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGrid_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGrid.CurrentRow == null || dataGrid.CurrentRow.DataBoundItem == null)
                return;
            var row = ((DataRowView)dataGrid.CurrentRow.DataBoundItem).Row;
            idTxt.Text = row.Field<int>("Id").ToString();
            responsableTxt.Text = row.Field<string>("Responsavel") ?? string.Empty;
            nameTxt.Text = row.Field<string>("Nome") ?? string.Empty;
            extraTxt.Text = row.Field<string>("Detalhes") ?? string.Empty;
            // Valor pode ser nulo
            var valorObj = row["Valor"];
            valueTxt.Text = valorObj == DBNull.Value ? string.Empty : Convert.ToDecimal(valorObj).ToString("N2", new CultureInfo("pt-BR"));
            var tipo = row.Field<string>("Tipo");
            typeFormAutoPart.Checked = string.Equals(tipo, "Peca", StringComparison.OrdinalIgnoreCase);
            typeFormService.Checked = string.Equals(tipo, "Servico", StringComparison.OrdinalIgnoreCase);
        }

        private void insertBtn_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idTxt.Text))
            {
                MessageBox.Show("Selecione um registro na tabela para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Validações
            string responsavel = responsableTxt.Text.Trim();
            string nome = nameTxt.Text.Trim();
            string detalhes = extraTxt.Text.Trim();
            string? tipo = typeFormAutoPart.Checked ? "Peca" : (typeFormService.Checked ? "Servico" : null);
            if (string.IsNullOrWhiteSpace(responsavel)) { MessageBox.Show("Informe o responsável."); return; }
            if (string.IsNullOrWhiteSpace(nome)) { MessageBox.Show("Informe o nome."); return; }
            if (tipo is null) { MessageBox.Show("Selecione o tipo."); return; }

            decimal? valor = null;
            if (!string.IsNullOrWhiteSpace(valueTxt.Text))
            {
                if (decimal.TryParse(valueTxt.Text.Trim(), NumberStyles.Number, new CultureInfo("pt-BR"), out var v) ||
                    decimal.TryParse(valueTxt.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out v))
                {
                    valor = v;
                }
                else
                {
                    MessageBox.Show("Valor inválido.");
                    return;
                }
            }

            try
            {
                using var conn = new MySqlConnection(DatabaseInitializer.AppConnectionString);
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"UPDATE registros
                                     SET Responsavel=@resp, Nome=@nome, Valor=@valor, Detalhes=@det, Tipo=@tipo
                                     WHERE Id=@id";
                cmd.Parameters.AddWithValue("@resp", responsavel);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@det", string.IsNullOrWhiteSpace(detalhes) ? (object)DBNull.Value : detalhes);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@id", int.Parse(idTxt.Text));
                if (valor.HasValue)
                    cmd.Parameters.AddWithValue("@valor", valor.Value);
                else
                    cmd.Parameters.AddWithValue("@valor", DBNull.Value);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi atualizado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

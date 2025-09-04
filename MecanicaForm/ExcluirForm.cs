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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using MySql.Data.MySqlClient;

namespace MecanicaForm
{
    public partial class ExcluirForm : Form
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

        public ExcluirForm()
        {
            InitializeComponent();

            menuTimer = new System.Windows.Forms.Timer();
            menuTimer.Interval = 10;
            menuTimer.Tick += MenuTimer_Tick;

            Load += ExcluirForm_Load;
            deleteBtn.Click += deleteBtn_Click;
        }

        private void HomePage_Load(object sender, EventArgs e)
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

        private void primeiroBtn_Click(object sender, EventArgs e)
        {
            var HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }

        private void anteriorBtn_Click(object sender, EventArgs e)
        {
            var InserirForm = new InserirForm();
            InserirForm.Show();
            this.Hide();
        }

        private void proximoBtn_Click(object sender, EventArgs e)
        {
            var AlterarForm = new AlterarForm();
            AlterarForm.Show();
            this.Hide();
        }

        private void ultimoBtn_Click(object sender, EventArgs e)
        {
            var ConsultarForm = new ConsultarForm();
            ConsultarForm.Show();
            this.Hide();
        }

        private void ExcluirForm_Load(object? sender, EventArgs e)
        {
            // Garantir grid carregada
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            try
            {
                using var conn = new MySqlConnection(DatabaseInitializer.AppConnectionString);
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT Id, Responsavel, Nome, Valor, Tipo, CriadoEm FROM registros ORDER BY CriadoEm DESC, Id DESC";
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

        private void deleteBtn_Click(object? sender, EventArgs e)
        {
            if (dataGrid.CurrentRow == null || dataGrid.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Selecione um registro para excluir.");
                return;
            }
            var row = ((DataRowView)dataGrid.CurrentRow.DataBoundItem).Row;
            int id = Convert.ToInt32(row["Id"]);
            string nome = row["Nome"]?.ToString() ?? "";
            var confirm = MessageBox.Show($"Tem certeza que deseja excluir o registro #{id} - {nome}?", "Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using var conn = new MySqlConnection(DatabaseInitializer.AppConnectionString);
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM registros WHERE Id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Registro excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi excluído.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

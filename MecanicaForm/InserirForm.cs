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
using System.Globalization;
using MySql.Data.MySqlClient;

namespace MecanicaForm
{
    public partial class InserirForm : Form
    {
        public InserirForm()
        {

            InitializeComponent();

            menuTimer = new System.Windows.Forms.Timer();
            menuTimer.Interval = 10;
            menuTimer.Tick += MenuTimer_Tick;

            // Campo ID é auto-incremento na tabela; desabilitar edição
            idTxt.Enabled = false;

            // Handler do botão de inserir
            insertBtn.Click += insertBtn_Click;
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


        private void HomePage_Load(object sender, EventArgs e)
        {
            leftMenu.Width = 0;
            leftMenu.Visible = false;
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

        private void anteriorBtn_Click(object sender, EventArgs e)
        {
            var HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }

        private void primeiroBtn_Click(object sender, EventArgs e)
        {
            var HomePage = new HomePage();
            HomePage.Show();
            this.Hide();
        }

        private void proximoBtn_Click(object sender, EventArgs e)
        {
            var ExcluirForm = new ExcluirForm();
            ExcluirForm.Show();
            this.Hide();
        }

        private void ultimoBtn_Click(object sender, EventArgs e)
        {
            var ConsultarForm = new ConsultarForm();
            ConsultarForm.Show();
            this.Hide();
        }

        private void insertBtn_Click(object? sender, EventArgs e)
        {
            // Validações básicas
            string responsavel = responsableTxt.Text.Trim();
            string nome = nameTxt.Text.Trim();
            string detalhes = extraTxt.Text.Trim();
            string? tipo = typeFormAutoPart.Checked ? "Peca" : (typeFormService.Checked ? "Servico" : null);

            if (string.IsNullOrWhiteSpace(responsavel))
            {
                MessageBox.Show("Informe o responsável.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                responsableTxt.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(nome))
            {
                MessageBox.Show("Informe o nome.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTxt.Focus();
                return;
            }
            if (tipo is null)
            {
                MessageBox.Show("Selecione o tipo (Peça ou Serviço).", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valor opcional
            decimal? valor = null;
            if (!string.IsNullOrWhiteSpace(valueTxt.Text))
            {
                // Tenta parse com pt-BR e Invariant
                if (decimal.TryParse(valueTxt.Text.Trim(), NumberStyles.Number, new CultureInfo("pt-BR"), out var v) ||
                    decimal.TryParse(valueTxt.Text.Trim(), NumberStyles.Number, CultureInfo.InvariantCulture, out v))
                {
                    valor = v;
                }
                else
                {
                    MessageBox.Show("Valor inválido.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valueTxt.Focus();
                    return;
                }
            }

            try
            {
                using var conn = new MySqlConnection(DatabaseInitializer.AppConnectionString);
                conn.Open();
                using var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO registros (Responsavel, Nome, Valor, Detalhes, Tipo)
                                     VALUES (@resp, @nome, @valor, @det, @tipo);";
                cmd.Parameters.AddWithValue("@resp", responsavel);
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@det", string.IsNullOrWhiteSpace(detalhes) ? (object)DBNull.Value : detalhes);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                // Valor pode ser nulo
                if (valor.HasValue)
                    cmd.Parameters.AddWithValue("@valor", valor.Value);
                else
                    cmd.Parameters.AddWithValue("@valor", DBNull.Value);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Registro inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi inserido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir no banco: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            // idTxt é auto-incremento, não limpar/editar
            responsableTxt.Text = string.Empty;
            nameTxt.Text = string.Empty;
            valueTxt.Text = string.Empty;
            extraTxt.Text = string.Empty;
            typeFormAutoPart.Checked = false;
            typeFormService.Checked = false;
            responsableTxt.Focus();
        }
    }
}

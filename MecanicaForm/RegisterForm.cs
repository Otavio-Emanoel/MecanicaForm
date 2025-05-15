using MecanicaForm;

namespace RegisterForm
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();
            string email = emailTxt.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            string userLine = $"{username};{password}";
            string filePath = "users.txt";

            // Verifica se o usuário já existe
            if (System.IO.File.Exists(filePath))
            {
                var lines = System.IO.File.ReadAllLines(filePath);
                if (lines.Any(line => line.Split(';')[0] == username))
                {
                    MessageBox.Show("Usuário já cadastrado.");
                    return;
                }
            }

            System.IO.File.AppendAllText(filePath, userLine + Environment.NewLine);
            MessageBox.Show("Cadastro realizado com sucesso!");
            var login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = !showPassword.Checked;
            confirmPasswordTxt.UseSystemPasswordChar = !showPassword.Checked;
        }

        private void goToLoginForm_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}

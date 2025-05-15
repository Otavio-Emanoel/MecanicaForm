using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MecanicaForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text.Trim();
            string password = passwordTxt.Text.Trim();
            string filePath = "users.txt";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Preencha todos os campos.");
                return;
            }

            if (!System.IO.File.Exists(filePath))
            {
                MessageBox.Show("Nenhum usuário cadastrado.");
                return;
            }

            var lines = System.IO.File.ReadAllLines(filePath);
            bool found = lines.Any(line =>
            {
                var parts = line.Split(';');
                return parts.Length == 2 && parts[0] == username && parts[1] == password;
            });

            if (found)
            {
                MessageBox.Show("Login realizado com sucesso!");

                var home = new HomeForm();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }

        private void goToRegisterForm_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm.RegisterForm();
            registerForm.Show();
            this.Hide();
        }
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTxt.UseSystemPasswordChar = !showPassword.Checked;
        }
    }
}

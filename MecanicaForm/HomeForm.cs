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
using RegisterForm;

namespace MecanicaForm
{
    public partial class HomeForm : Form
    {
        // Métodos nativos e constantes agora dentro da classe
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public HomeForm()
        {
            InitializeComponent();
            windowTopHome.MouseDown += windowTopHome_MouseDown;
        }

        private void closeWindow_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void closeWindow_MouseHover(object sender, EventArgs e)
        {
            closeWindow.BackColor = Color.Red;
        }

        private void closeWindow_MouseLeave(object sender, EventArgs e)
        {
            closeWindow.BackColor = Color.Transparent;
        }

        private void windowTopHome_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            Form registerForm = new RegisterForm.RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
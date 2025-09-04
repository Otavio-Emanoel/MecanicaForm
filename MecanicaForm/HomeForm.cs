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
            // Aparência geral
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Paint += HomeForm_PaintGradient;
            Resize += HomeForm_Resize;
            // Estilizações dos elementos
            ApplyRoundedCorners(heroCard, 16);
            ApplyRoundedCorners(registerBtn, 12);
            ApplyRoundedCorners(loginBtn, 12);
            heroCard.Padding = new Padding(16);
            // Sombra suave do card
            heroCard.Paint += (s, e) =>
            {
                using var shadow = new SolidBrush(Color.FromArgb(60, 0, 0, 0));
                var r = heroCard.ClientRectangle;
                r.Inflate(6, 6);
                e.Graphics.FillRectangle(shadow, new Rectangle(4, 4, r.Width - 8, r.Height - 8));
            };
            // Centralizar card de forma responsiva na área útil
            Layout += (s, e) => CenterHeroCard();
            CenterHeroCard();
        }

    private void closeWindow_Click(object? sender, EventArgs e)
        {
            Close();
        }

    private void closeWindow_MouseHover(object? sender, EventArgs e)
        {
            closeWindow.BackColor = Color.Red;
        }

    private void closeWindow_MouseLeave(object? sender, EventArgs e)
        {
            closeWindow.BackColor = Color.Transparent;
        }

    private void windowTopHome_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

    private void registerBtn_Click(object? sender, EventArgs e)
        {
            Form registerForm = new RegisterForm.RegisterForm();
            registerForm.Show();
            this.Hide();
        }

    private void loginBtn_Click(object? sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        // Fundo em gradiente
    private void HomeForm_PaintGradient(object? sender, PaintEventArgs e)
        {
            var rect = ClientRectangle;
            rect.Y += windowTopHome.Height;
            rect.Height -= windowTopHome.Height;
            using var lg = new System.Drawing.Drawing2D.LinearGradientBrush(rect, Color.FromArgb(18, 18, 20), Color.FromArgb(30, 30, 36), 45f);
            e.Graphics.FillRectangle(lg, rect);
        }

        private void HomeForm_Resize(object? sender, EventArgs e)
        {
            Invalidate();
            CenterHeroCard();
        }

        private void CenterHeroCard()
        {
            if (contentPanel == null || heroCard == null) return;
            var area = contentPanel.ClientRectangle;
            heroCard.Left = Math.Max(40, area.Left + (area.Width - heroCard.Width) / 2 - 180);
            heroCard.Top = Math.Max(60, area.Top + (area.Height - heroCard.Height) / 2 - 20);
        }

        // Utilitário para aplicar cantos arredondados
        private static void ApplyRoundedCorners(Control control, int radius)
        {
            try
            {
                var path = new System.Drawing.Drawing2D.GraphicsPath();
                var r = control.ClientRectangle;
                int d = radius * 2;
                path.AddArc(r.X, r.Y, d, d, 180, 90);
                path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
                path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
                path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
                path.CloseAllFigures();
                control.Region = new Region(path);
                control.Resize += (s, e) =>
                {
                    var p = new System.Drawing.Drawing2D.GraphicsPath();
                    var rr = control.ClientRectangle;
                    int dd = radius * 2;
                    p.AddArc(rr.X, rr.Y, dd, dd, 180, 90);
                    p.AddArc(rr.Right - dd, rr.Y, dd, dd, 270, 90);
                    p.AddArc(rr.Right - dd, rr.Bottom - dd, dd, dd, 0, 90);
                    p.AddArc(rr.X, rr.Bottom - dd, dd, dd, 90, 90);
                    p.CloseAllFigures();
                    control.Region = new Region(p);
                };
            }
            catch
            {
                // Ignorar se falhar (ex.: em modo designer)
            }
        }
    }
}
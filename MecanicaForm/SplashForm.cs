namespace MecanicaForm
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            // Aparência
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            Paint += SplashForm_PaintGradient;
            Resize += SplashForm_Resize;
            // Estilos
            ApplyRoundedCorners(heroCard, 16);
            Layout += (s, e) => CenterHeroCard();
            CenterHeroCard();
        }

        private async void SplashForm_Load(object? sender, EventArgs e)
        {

            await Task.Delay(500);

            for (int i = 0; i <= 100; i++)
            {
                progressBarInitialize.Value = i;
                loadingText.Text = $"Carregando: {i.ToString()}%";
                // Atualiza barra customizada
                UpdateCustomProgress(i);
                await Task.Delay(10);
                    
            }

            HomeForm homeForm = new HomeForm();
            homeForm.Show();

            this.Hide();
        }

        private void UpdateCustomProgress(int percent)
        {
            try
            {
                var width = (int)(progressContainer.Width * (percent / 100.0));
                progressFill.Width = Math.Max(0, Math.Min(progressContainer.Width, width));
            }
            catch
            {
                // ignora se ainda não estiver criado
            }
        }

        private void SplashForm_PaintGradient(object? sender, PaintEventArgs e)
        {
            var rect = ClientRectangle;
            using var lg = new System.Drawing.Drawing2D.LinearGradientBrush(rect, Color.FromArgb(18, 18, 20), Color.FromArgb(34, 34, 40), 45f);
            e.Graphics.FillRectangle(lg, rect);
        }

        private void SplashForm_Resize(object? sender, EventArgs e)
        {
            Invalidate();
            CenterHeroCard();
        }

        private void CenterHeroCard()
        {
            if (contentPanel == null || heroCard == null) return;
            var area = contentPanel.ClientRectangle;
            heroCard.Left = area.Left + (area.Width - heroCard.Width) / 2;
            heroCard.Top = area.Top + (area.Height - heroCard.Height) / 2;
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

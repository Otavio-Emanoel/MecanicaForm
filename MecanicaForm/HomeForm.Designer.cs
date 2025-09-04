namespace MecanicaForm
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            windowTopHome = new Panel();
            closeWindow = new PictureBox();
            contentPanel = new Panel();
            heroCard = new Panel();
            titleLabel = new Label();
            subtitleLabel = new Label();
            registerBtn = new Button();
            loginBtn = new Button();
            pictureBox1 = new PictureBox();
            windowTopHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeWindow).BeginInit();
            contentPanel.SuspendLayout();
            heroCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // windowTopHome
            // 
            windowTopHome.BackColor = Color.FromArgb(80, 82, 82);
            windowTopHome.Controls.Add(closeWindow);
            windowTopHome.Dock = DockStyle.Top;
            windowTopHome.Location = new Point(0, 0);
            windowTopHome.Name = "windowTopHome";
            windowTopHome.Size = new Size(1000, 30);
            windowTopHome.TabIndex = 0;
            // 
            // closeWindow
            // 
            closeWindow.Cursor = Cursors.Hand;
            closeWindow.Image = Properties.Resources.close;
            closeWindow.Location = new Point(964, 4);
            closeWindow.Name = "closeWindow";
            closeWindow.Padding = new Padding(5);
            closeWindow.Size = new Size(24, 24);
            closeWindow.SizeMode = PictureBoxSizeMode.Zoom;
            closeWindow.TabIndex = 0;
            closeWindow.TabStop = false;
            closeWindow.Click += closeWindow_Click;
            closeWindow.MouseLeave += closeWindow_MouseLeave;
            closeWindow.MouseHover += closeWindow_MouseHover;
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 30);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(40, 40, 40, 40);
            contentPanel.Size = new Size(1000, 570);
            contentPanel.TabIndex = 4;
            contentPanel.BackColor = Color.Transparent;
            contentPanel.Controls.Add(heroCard);
            contentPanel.Controls.Add(pictureBox1);
            // 
            // heroCard
            // 
            heroCard.BackColor = Color.FromArgb(32, 34, 37);
            heroCard.Location = new Point(60, 90);
            heroCard.Name = "heroCard";
            heroCard.Size = new Size(420, 360);
            heroCard.TabIndex = 0;
            heroCard.Controls.Add(titleLabel);
            heroCard.Controls.Add(subtitleLabel);
            heroCard.Controls.Add(registerBtn);
            heroCard.Controls.Add(loginBtn);
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(24, 24);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(230, 51);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Bem-vindo";
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular);
            subtitleLabel.ForeColor = Color.Silver;
            subtitleLabel.Location = new Point(28, 85);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(345, 23);
            subtitleLabel.TabIndex = 1;
            subtitleLabel.Text = "Gerencie serviços e peças de forma simples.";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(0, 122, 204);
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 105, 176);
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(28, 140);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(360, 60);
            registerBtn.TabIndex = 2;
            registerBtn.Text = "Cadastro";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(50, 54, 57);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderColor = Color.FromArgb(90, 94, 97);
            loginBtn.FlatAppearance.BorderSize = 2;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(28, 220);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(360, 60);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(560, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 380);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 12, 12);
            ClientSize = new Size(1000, 600);
            Controls.Add(contentPanel);
            Controls.Add(windowTopHome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            windowTopHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeWindow).EndInit();
            contentPanel.ResumeLayout(false);
            heroCard.ResumeLayout(false);
            heroCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

    private Panel windowTopHome;
    private Button registerBtn;
    private Button loginBtn;
    private PictureBox closeWindow;
    private PictureBox pictureBox1;
    private Panel contentPanel;
    private Panel heroCard;
    private Label titleLabel;
    private Label subtitleLabel;
    }
}
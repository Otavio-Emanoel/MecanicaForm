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
            registerBtn = new Button();
            loginBtn = new Button();
            pictureBox1 = new PictureBox();
            windowTopHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeWindow).BeginInit();
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
            // registerBtn
            // 
            registerBtn.BackColor = Color.Transparent;
            registerBtn.BackgroundImageLayout = ImageLayout.None;
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 2;
            registerBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(5, 5, 75);
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(67, 203);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(263, 81);
            registerBtn.TabIndex = 1;
            registerBtn.Text = "Cadastro";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.White;
            loginBtn.BackgroundImageLayout = ImageLayout.None;
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            loginBtn.ForeColor = Color.Black;
            loginBtn.Location = new Point(67, 316);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(263, 81);
            loginBtn.TabIndex = 2;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(595, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 12, 12);
            ClientSize = new Size(1000, 600);
            Controls.Add(pictureBox1);
            Controls.Add(loginBtn);
            Controls.Add(registerBtn);
            Controls.Add(windowTopHome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            windowTopHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeWindow).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel windowTopHome;
        private Button registerBtn;
        private Button loginBtn;
        private PictureBox closeWindow;
        private PictureBox pictureBox1;
    }
}
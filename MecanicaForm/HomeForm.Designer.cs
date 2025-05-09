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
            panel1 = new Panel();
            closeWindow = new PictureBox();
            registerBtn = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeWindow).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(80, 82, 82);
            panel1.Controls.Add(closeWindow);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 30);
            panel1.TabIndex = 0;
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
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(67, 316);
            button1.Name = "button1";
            button1.Size = new Size(263, 81);
            button1.TabIndex = 2;
            button1.Text = "Cadastro";
            button1.UseVisualStyleBackColor = false;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(20, 12, 12);
            ClientSize = new Size(1000, 600);
            Controls.Add(button1);
            Controls.Add(registerBtn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeWindow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button registerBtn;
        private Button button1;
        private PictureBox closeWindow;
    }
}
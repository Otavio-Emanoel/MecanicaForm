namespace MecanicaForm
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            goToLoginForm = new Button();
            loginBtn = new Button();
            emailTxt = new TextBox();
            label5 = new Label();
            showPassword = new CheckBox();
            passwordTxt = new TextBox();
            label3 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // goToLoginForm
            // 
            goToLoginForm.BackColor = Color.Transparent;
            goToLoginForm.Cursor = Cursors.Hand;
            goToLoginForm.FlatAppearance.BorderColor = Color.FromArgb(96, 86, 194);
            goToLoginForm.FlatStyle = FlatStyle.Flat;
            goToLoginForm.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            goToLoginForm.ForeColor = Color.FromArgb(96, 86, 194);
            goToLoginForm.Location = new Point(28, 343);
            goToLoginForm.Name = "goToLoginForm";
            goToLoginForm.Size = new Size(216, 35);
            goToLoginForm.TabIndex = 24;
            goToLoginForm.Text = "NÃO TENHO CONTA";
            goToLoginForm.UseVisualStyleBackColor = false;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.FromArgb(96, 86, 194);
            loginBtn.Cursor = Cursors.Hand;
            loginBtn.FlatAppearance.BorderSize = 0;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.White;
            loginBtn.Location = new Point(28, 292);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(216, 35);
            loginBtn.TabIndex = 23;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = false;
            // 
            // emailTxt
            // 
            emailTxt.BackColor = Color.FromArgb(230, 231, 233);
            emailTxt.BorderStyle = BorderStyle.None;
            emailTxt.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.ForeColor = SystemColors.WindowText;
            emailTxt.Location = new Point(28, 139);
            emailTxt.Multiline = true;
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(216, 28);
            emailTxt.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.ForeColor = Color.FromArgb(164, 165, 169);
            label5.Location = new Point(28, 118);
            label5.Name = "label5";
            label5.Size = new Size(39, 17);
            label5.TabIndex = 21;
            label5.Text = "Email";
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Cursor = Cursors.Hand;
            showPassword.FlatStyle = FlatStyle.Flat;
            showPassword.Font = new Font("Segoe UI", 10F);
            showPassword.ForeColor = Color.FromArgb(164, 165, 169);
            showPassword.Location = new Point(130, 243);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(114, 23);
            showPassword.TabIndex = 20;
            showPassword.Text = "Mostrar senha";
            showPassword.UseVisualStyleBackColor = true;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.FromArgb(230, 231, 233);
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.ForeColor = SystemColors.WindowText;
            passwordTxt.Location = new Point(28, 197);
            passwordTxt.Multiline = true;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(216, 28);
            passwordTxt.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = Color.FromArgb(164, 165, 169);
            label3.Location = new Point(28, 177);
            label3.Name = "label3";
            label3.Size = new Size(43, 17);
            label3.TabIndex = 16;
            label3.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(96, 86, 194);
            label1.Location = new Point(28, 68);
            label1.Name = "label1";
            label1.Size = new Size(78, 27);
            label1.TabIndex = 13;
            label1.Text = "Login";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(272, 430);
            Controls.Add(pictureBox1);
            Controls.Add(goToLoginForm);
            Controls.Add(loginBtn);
            Controls.Add(emailTxt);
            Controls.Add(label5);
            Controls.Add(showPassword);
            Controls.Add(passwordTxt);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button goToLoginForm;
        private Button loginBtn;
        private TextBox emailTxt;
        private Label label5;
        private CheckBox showPassword;
        private TextBox passwordTxt;
        private Label label3;
        private Label label1;
    }
}
namespace RegisterForm
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            label2 = new Label();
            usernameTxt = new TextBox();
            passwordTxt = new TextBox();
            label3 = new Label();
            confirmPasswordTxt = new TextBox();
            label4 = new Label();
            showPassword = new CheckBox();
            emailTxt = new TextBox();
            label5 = new Label();
            registerBtn = new Button();
            goToLoginForm = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(96, 86, 194);
            label1.Location = new Point(28, 68);
            label1.Name = "label1";
            label1.Size = new Size(121, 27);
            label1.TabIndex = 0;
            label1.Text = "Cadastro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 113);
            label2.Name = "label2";
            label2.Size = new Size(116, 19);
            label2.TabIndex = 1;
            label2.Text = "Nome de Usuario";
            // 
            // usernameTxt
            // 
            usernameTxt.BackColor = Color.FromArgb(230, 231, 233);
            usernameTxt.BorderStyle = BorderStyle.None;
            usernameTxt.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameTxt.ForeColor = SystemColors.WindowText;
            usernameTxt.Location = new Point(28, 136);
            usernameTxt.Multiline = true;
            usernameTxt.Name = "usernameTxt";
            usernameTxt.Size = new Size(216, 28);
            usernameTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            passwordTxt.BackColor = Color.FromArgb(230, 231, 233);
            passwordTxt.BorderStyle = BorderStyle.None;
            passwordTxt.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTxt.ForeColor = SystemColors.WindowText;
            passwordTxt.Location = new Point(28, 254);
            passwordTxt.Multiline = true;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(216, 28);
            passwordTxt.TabIndex = 3;
            passwordTxt.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 231);
            label3.Name = "label3";
            label3.Size = new Size(46, 19);
            label3.TabIndex = 3;
            label3.Text = "Senha";
            // 
            // confirmPasswordTxt
            // 
            confirmPasswordTxt.BackColor = Color.FromArgb(230, 231, 233);
            confirmPasswordTxt.BorderStyle = BorderStyle.None;
            confirmPasswordTxt.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPasswordTxt.ForeColor = SystemColors.WindowText;
            confirmPasswordTxt.Location = new Point(28, 313);
            confirmPasswordTxt.Multiline = true;
            confirmPasswordTxt.Name = "confirmPasswordTxt";
            confirmPasswordTxt.Size = new Size(216, 28);
            confirmPasswordTxt.TabIndex = 4;
            confirmPasswordTxt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 290);
            label4.Name = "label4";
            label4.Size = new Size(110, 19);
            label4.TabIndex = 5;
            label4.Text = "Confirmar senha";
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Cursor = Cursors.Hand;
            showPassword.FlatStyle = FlatStyle.Flat;
            showPassword.Location = new Point(130, 347);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(114, 23);
            showPassword.TabIndex = 5;
            showPassword.Text = "Mostrar senha";
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged;

            // 
            // emailTxt
            // 
            emailTxt.BackColor = Color.FromArgb(230, 231, 233);
            emailTxt.BorderStyle = BorderStyle.None;
            emailTxt.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTxt.ForeColor = SystemColors.WindowText;
            emailTxt.Location = new Point(28, 195);
            emailTxt.Multiline = true;
            emailTxt.Name = "emailTxt";
            emailTxt.Size = new Size(216, 28);
            emailTxt.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 172);
            label5.Name = "label5";
            label5.Size = new Size(41, 19);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.FromArgb(96, 86, 194);
            registerBtn.Cursor = Cursors.Hand;
            registerBtn.FlatAppearance.BorderSize = 0;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.White;
            registerBtn.Location = new Point(28, 387);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(216, 35);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "CADASTRAR";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // goToLoginForm
            // 
            goToLoginForm.BackColor = Color.Transparent;
            goToLoginForm.Cursor = Cursors.Hand;
            goToLoginForm.FlatAppearance.BorderColor = Color.FromArgb(96, 86, 194);
            goToLoginForm.FlatStyle = FlatStyle.Flat;
            goToLoginForm.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            goToLoginForm.ForeColor = Color.FromArgb(96, 86, 194);
            goToLoginForm.Location = new Point(28, 438);
            goToLoginForm.Name = "goToLoginForm";
            goToLoginForm.Size = new Size(216, 35);
            goToLoginForm.TabIndex = 7;
            goToLoginForm.Text = "JÁ TENHO CONTA";
            goToLoginForm.UseVisualStyleBackColor = false;
            goToLoginForm.Click += goToLoginForm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(210, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(272, 522);
            Controls.Add(pictureBox1);
            Controls.Add(goToLoginForm);
            Controls.Add(registerBtn);
            Controls.Add(emailTxt);
            Controls.Add(label5);
            Controls.Add(showPassword);
            Controls.Add(confirmPasswordTxt);
            Controls.Add(label4);
            Controls.Add(passwordTxt);
            Controls.Add(label3);
            Controls.Add(usernameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameTxt;
        private TextBox passwordTxt;
        private Label label3;
        private TextBox confirmPasswordTxt;
        private Label label4;
        private CheckBox showPassword;
        private TextBox emailTxt;
        private Label label5;
        private Button registerBtn;
        private Button goToLoginForm;
        private PictureBox pictureBox1;
    }
}

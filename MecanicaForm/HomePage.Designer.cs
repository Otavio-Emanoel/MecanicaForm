﻿namespace MecanicaForm
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            windowTop = new Panel();
            closeWindowBtn = new PictureBox();
            openMenu = new PictureBox();
            leftMenu = new Panel();
            homePageBtn = new Button();
            sairBtn = new Button();
            consultarBtn = new Button();
            alterarBtn = new Button();
            excluirBtn = new Button();
            inserirBtn = new Button();
            ultimoBtn = new Button();
            proximoBtn = new Button();
            anteriorBtn = new Button();
            primeiroBtn = new Button();
            pictureBox1 = new PictureBox();
            windowTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeWindowBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openMenu).BeginInit();
            leftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // windowTop
            // 
            windowTop.BackColor = Color.FromArgb(96, 86, 194);
            windowTop.Controls.Add(closeWindowBtn);
            windowTop.Controls.Add(openMenu);
            windowTop.Dock = DockStyle.Top;
            windowTop.Location = new Point(0, 0);
            windowTop.Name = "windowTop";
            windowTop.Size = new Size(1184, 50);
            windowTop.TabIndex = 0;
            windowTop.MouseDown += windowTop_MouseDown;
            // 
            // closeWindowBtn
            // 
            closeWindowBtn.Cursor = Cursors.Hand;
            closeWindowBtn.Dock = DockStyle.Right;
            closeWindowBtn.Image = Properties.Resources.close;
            closeWindowBtn.Location = new Point(1134, 0);
            closeWindowBtn.Margin = new Padding(0);
            closeWindowBtn.Name = "closeWindowBtn";
            closeWindowBtn.Size = new Size(50, 50);
            closeWindowBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            closeWindowBtn.TabIndex = 1;
            closeWindowBtn.TabStop = false;
            closeWindowBtn.Click += closeWindowBtn_Click;
            // 
            // openMenu
            // 
            openMenu.Cursor = Cursors.Hand;
            openMenu.Dock = DockStyle.Left;
            openMenu.Image = Properties.Resources.menu;
            openMenu.Location = new Point(0, 0);
            openMenu.Margin = new Padding(0);
            openMenu.Name = "openMenu";
            openMenu.Size = new Size(50, 50);
            openMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            openMenu.TabIndex = 0;
            openMenu.TabStop = false;
            openMenu.Click += openMenu_Click;
            // 
            // leftMenu
            // 
            leftMenu.BackColor = Color.FromArgb(146, 136, 244);
            leftMenu.Controls.Add(homePageBtn);
            leftMenu.Controls.Add(sairBtn);
            leftMenu.Controls.Add(consultarBtn);
            leftMenu.Controls.Add(alterarBtn);
            leftMenu.Controls.Add(excluirBtn);
            leftMenu.Controls.Add(inserirBtn);
            leftMenu.Dock = DockStyle.Left;
            leftMenu.Location = new Point(0, 50);
            leftMenu.Name = "leftMenu";
            leftMenu.Size = new Size(258, 661);
            leftMenu.TabIndex = 1;
            leftMenu.Visible = false;
            // 
            // homePageBtn
            // 
            homePageBtn.BackColor = Color.FromArgb(146, 136, 244);
            homePageBtn.FlatAppearance.BorderSize = 0;
            homePageBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 36, 144);
            homePageBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            homePageBtn.FlatStyle = FlatStyle.Flat;
            homePageBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            homePageBtn.ForeColor = Color.White;
            homePageBtn.Location = new Point(3, 3);
            homePageBtn.Name = "homePageBtn";
            homePageBtn.Size = new Size(252, 100);
            homePageBtn.TabIndex = 5;
            homePageBtn.Text = "INÍCIO";
            homePageBtn.UseVisualStyleBackColor = false;
            // 
            // sairBtn
            // 
            sairBtn.BackColor = Color.FromArgb(146, 136, 244);
            sairBtn.FlatAppearance.BorderSize = 0;
            sairBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 36, 144);
            sairBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            sairBtn.FlatStyle = FlatStyle.Flat;
            sairBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            sairBtn.ForeColor = Color.White;
            sairBtn.Location = new Point(3, 548);
            sairBtn.Name = "sairBtn";
            sairBtn.Size = new Size(252, 100);
            sairBtn.TabIndex = 4;
            sairBtn.Text = "SAIR";
            sairBtn.UseVisualStyleBackColor = false;
            // 
            // consultarBtn
            // 
            consultarBtn.BackColor = Color.FromArgb(146, 136, 244);
            consultarBtn.FlatAppearance.BorderSize = 0;
            consultarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 36, 144);
            consultarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            consultarBtn.FlatStyle = FlatStyle.Flat;
            consultarBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            consultarBtn.ForeColor = Color.White;
            consultarBtn.Location = new Point(3, 439);
            consultarBtn.Name = "consultarBtn";
            consultarBtn.Size = new Size(252, 100);
            consultarBtn.TabIndex = 3;
            consultarBtn.Text = "CONSULTAR";
            consultarBtn.UseVisualStyleBackColor = false;
            // 
            // alterarBtn
            // 
            alterarBtn.BackColor = Color.FromArgb(146, 136, 244);
            alterarBtn.FlatAppearance.BorderSize = 0;
            alterarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 36, 144);
            alterarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            alterarBtn.FlatStyle = FlatStyle.Flat;
            alterarBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            alterarBtn.ForeColor = Color.White;
            alterarBtn.Location = new Point(3, 330);
            alterarBtn.Name = "alterarBtn";
            alterarBtn.Size = new Size(252, 100);
            alterarBtn.TabIndex = 2;
            alterarBtn.Text = "ALTERAR";
            alterarBtn.UseVisualStyleBackColor = false;
            // 
            // excluirBtn
            // 
            excluirBtn.BackColor = Color.FromArgb(146, 136, 244);
            excluirBtn.FlatAppearance.BorderSize = 0;
            excluirBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 36, 144);
            excluirBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            excluirBtn.FlatStyle = FlatStyle.Flat;
            excluirBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            excluirBtn.ForeColor = Color.White;
            excluirBtn.Location = new Point(3, 221);
            excluirBtn.Name = "excluirBtn";
            excluirBtn.Size = new Size(252, 100);
            excluirBtn.TabIndex = 1;
            excluirBtn.Text = "EXCLUIR";
            excluirBtn.UseVisualStyleBackColor = false;
            // 
            // inserirBtn
            // 
            inserirBtn.BackColor = Color.FromArgb(146, 136, 244);
            inserirBtn.FlatAppearance.BorderSize = 0;
            inserirBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(46, 36, 144);
            inserirBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            inserirBtn.FlatStyle = FlatStyle.Flat;
            inserirBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            inserirBtn.ForeColor = Color.White;
            inserirBtn.Location = new Point(3, 112);
            inserirBtn.Name = "inserirBtn";
            inserirBtn.Size = new Size(252, 100);
            inserirBtn.TabIndex = 0;
            inserirBtn.Text = "INSERIR";
            inserirBtn.UseVisualStyleBackColor = false;
            inserirBtn.Click += inserirBtn_Click;
            // 
            // ultimoBtn
            // 
            ultimoBtn.Anchor = AnchorStyles.Bottom;
            ultimoBtn.BackColor = Color.FromArgb(96, 96, 120);
            ultimoBtn.FlatAppearance.BorderSize = 0;
            ultimoBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            ultimoBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            ultimoBtn.FlatStyle = FlatStyle.Flat;
            ultimoBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            ultimoBtn.ForeColor = Color.White;
            ultimoBtn.Location = new Point(1048, 653);
            ultimoBtn.Name = "ultimoBtn";
            ultimoBtn.Size = new Size(124, 45);
            ultimoBtn.TabIndex = 6;
            ultimoBtn.Text = "ÚLTIMO";
            ultimoBtn.UseVisualStyleBackColor = false;
            // 
            // proximoBtn
            // 
            proximoBtn.Anchor = AnchorStyles.Bottom;
            proximoBtn.BackColor = Color.FromArgb(96, 96, 120);
            proximoBtn.FlatAppearance.BorderSize = 0;
            proximoBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            proximoBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            proximoBtn.FlatStyle = FlatStyle.Flat;
            proximoBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            proximoBtn.ForeColor = Color.White;
            proximoBtn.Location = new Point(918, 653);
            proximoBtn.Name = "proximoBtn";
            proximoBtn.Size = new Size(124, 45);
            proximoBtn.TabIndex = 7;
            proximoBtn.Text = "PRÓXIMO";
            proximoBtn.UseVisualStyleBackColor = false;
            // 
            // anteriorBtn
            // 
            anteriorBtn.Anchor = AnchorStyles.Bottom;
            anteriorBtn.BackColor = Color.FromArgb(96, 96, 120);
            anteriorBtn.FlatAppearance.BorderSize = 0;
            anteriorBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            anteriorBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            anteriorBtn.FlatStyle = FlatStyle.Flat;
            anteriorBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            anteriorBtn.ForeColor = Color.White;
            anteriorBtn.Location = new Point(788, 653);
            anteriorBtn.Name = "anteriorBtn";
            anteriorBtn.Size = new Size(124, 45);
            anteriorBtn.TabIndex = 8;
            anteriorBtn.Text = "ANTERIOR";
            anteriorBtn.UseVisualStyleBackColor = false;
            // 
            // primeiroBtn
            // 
            primeiroBtn.Anchor = AnchorStyles.Bottom;
            primeiroBtn.BackColor = Color.FromArgb(96, 96, 120);
            primeiroBtn.FlatAppearance.BorderSize = 0;
            primeiroBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            primeiroBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            primeiroBtn.FlatStyle = FlatStyle.Flat;
            primeiroBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            primeiroBtn.ForeColor = Color.White;
            primeiroBtn.Location = new Point(658, 653);
            primeiroBtn.Name = "primeiroBtn";
            primeiroBtn.Size = new Size(124, 45);
            primeiroBtn.TabIndex = 9;
            primeiroBtn.Text = "PRIMEIRO";
            primeiroBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(480, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(514, 443);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(pictureBox1);
            Controls.Add(primeiroBtn);
            Controls.Add(anteriorBtn);
            Controls.Add(proximoBtn);
            Controls.Add(ultimoBtn);
            Controls.Add(leftMenu);
            Controls.Add(windowTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            windowTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeWindowBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)openMenu).EndInit();
            leftMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel windowTop;
        private PictureBox openMenu;
        private Panel leftMenu;
        private Button alterarBtn;
        private Button excluirBtn;
        private Button inserirBtn;
        private Button sairBtn;
        private Button consultarBtn;
        private PictureBox closeWindowBtn;
        private Button homePageBtn;
        private Button ultimoBtn;
        private Button proximoBtn;
        private Button anteriorBtn;
        private Button primeiroBtn;
        private PictureBox pictureBox1;
    }
}
namespace MecanicaForm
{
    partial class AlterarForm
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
            primeiroBtn = new Button();
            anteriorBtn = new Button();
            proximoBtn = new Button();
            ultimoBtn = new Button();
            leftMenu = new Panel();
            homePageBtn = new Button();
            sairBtn = new Button();
            consultarBtn = new Button();
            alterarBtn = new Button();
            excluirBtn = new Button();
            inserirBtn = new Button();
            windowTop = new Panel();
            closeWindowBtn = new PictureBox();
            openMenu = new PictureBox();
            panel1 = new Panel();
            dataGrid = new DataGridView();
            label6 = new Label();
            insertBtn = new Button();
            typeFormService = new RadioButton();
            typeFormAutoPart = new RadioButton();
            extraTxt = new TextBox();
            label4 = new Label();
            valueTxt = new TextBox();
            label5 = new Label();
            nameTxt = new TextBox();
            label3 = new Label();
            responsableTxt = new TextBox();
            label1 = new Label();
            idTxt = new TextBox();
            label2 = new Label();
            leftMenu.SuspendLayout();
            windowTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeWindowBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openMenu).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            primeiroBtn.TabIndex = 19;
            primeiroBtn.Text = "PRIMEIRO";
            primeiroBtn.UseVisualStyleBackColor = false;
            primeiroBtn.Click += primeiroBtn_Click;
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
            anteriorBtn.TabIndex = 18;
            anteriorBtn.Text = "ANTERIOR";
            anteriorBtn.UseVisualStyleBackColor = false;
            anteriorBtn.Click += anteriorBtn_Click;
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
            proximoBtn.TabIndex = 17;
            proximoBtn.Text = "PRÓXIMO";
            proximoBtn.UseVisualStyleBackColor = false;
            proximoBtn.Click += proximoBtn_Click;
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
            ultimoBtn.TabIndex = 16;
            ultimoBtn.Text = "ÚLTIMO";
            ultimoBtn.UseVisualStyleBackColor = false;
            ultimoBtn.Click += ultimoBtn_Click;
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
            leftMenu.TabIndex = 15;
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
            homePageBtn.Click += homePageBtn_Click;
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
            sairBtn.Click += sairBtn_Click;
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
            consultarBtn.Click += consultarBtn_Click;
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
            excluirBtn.Click += excluirBtn_Click;
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
            // windowTop
            // 
            windowTop.BackColor = Color.FromArgb(96, 86, 194);
            windowTop.Controls.Add(closeWindowBtn);
            windowTop.Controls.Add(openMenu);
            windowTop.Dock = DockStyle.Top;
            windowTop.Location = new Point(0, 0);
            windowTop.Name = "windowTop";
            windowTop.Size = new Size(1184, 50);
            windowTop.TabIndex = 14;
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(230, 230, 230);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(insertBtn);
            panel1.Controls.Add(typeFormService);
            panel1.Controls.Add(typeFormAutoPart);
            panel1.Controls.Add(extraTxt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(valueTxt);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(nameTxt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(responsableTxt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(idTxt);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(261, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 471);
            panel1.TabIndex = 20;

            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.Location = new Point(781, 120);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(383, 471);
            dataGrid.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(96, 86, 194);
            label6.Location = new Point(18, 21);
            label6.Name = "label6";
            label6.Size = new Size(273, 27);
            label6.TabIndex = 15;
            label6.Text = "Formulário de Alterar";
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.FromArgb(96, 86, 194);
            insertBtn.Cursor = Cursors.Hand;
            insertBtn.FlatAppearance.BorderSize = 0;
            insertBtn.FlatStyle = FlatStyle.Flat;
            insertBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertBtn.ForeColor = Color.White;
            insertBtn.Location = new Point(18, 398);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(216, 35);
            insertBtn.TabIndex = 14;
            insertBtn.Text = "SALVAR";
            insertBtn.UseVisualStyleBackColor = false;
            // 
            // typeFormService
            // 
            typeFormService.AutoSize = true;
            typeFormService.Location = new Point(171, 360);
            typeFormService.Name = "typeFormService";
            typeFormService.Size = new Size(63, 19);
            typeFormService.TabIndex = 13;
            typeFormService.TabStop = true;
            typeFormService.Text = "Serviço";
            typeFormService.UseVisualStyleBackColor = true;
            // 
            // typeFormAutoPart
            // 
            typeFormAutoPart.AutoSize = true;
            typeFormAutoPart.Location = new Point(18, 360);
            typeFormAutoPart.Name = "typeFormAutoPart";
            typeFormAutoPart.Size = new Size(50, 19);
            typeFormAutoPart.TabIndex = 12;
            typeFormAutoPart.TabStop = true;
            typeFormAutoPart.Text = "Peça";
            typeFormAutoPart.UseVisualStyleBackColor = true;
            // 
            // extraTxt
            // 
            extraTxt.BackColor = Color.FromArgb(250, 251, 253);
            extraTxt.BorderStyle = BorderStyle.None;
            extraTxt.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            extraTxt.ForeColor = SystemColors.WindowText;
            extraTxt.Location = new Point(18, 317);
            extraTxt.Name = "extraTxt";
            extraTxt.Size = new Size(216, 20);
            extraTxt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 294);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 11;
            label4.Text = "Detalhes adicionais";
            // 
            // valueTxt
            // 
            valueTxt.BackColor = Color.FromArgb(250, 251, 253);
            valueTxt.BorderStyle = BorderStyle.None;
            valueTxt.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valueTxt.ForeColor = SystemColors.WindowText;
            valueTxt.Location = new Point(18, 261);
            valueTxt.Name = "valueTxt";
            valueTxt.Size = new Size(216, 20);
            valueTxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 238);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 9;
            label5.Text = "Valor";
            // 
            // nameTxt
            // 
            nameTxt.BackColor = Color.FromArgb(250, 251, 253);
            nameTxt.BorderStyle = BorderStyle.None;
            nameTxt.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTxt.ForeColor = SystemColors.WindowText;
            nameTxt.Location = new Point(18, 209);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(216, 20);
            nameTxt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 186);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "Nome";
            // 
            // responsableTxt
            // 
            responsableTxt.BackColor = Color.FromArgb(250, 251, 253);
            responsableTxt.BorderStyle = BorderStyle.None;
            responsableTxt.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            responsableTxt.ForeColor = SystemColors.WindowText;
            responsableTxt.Location = new Point(18, 153);
            responsableTxt.Name = "responsableTxt";
            responsableTxt.Size = new Size(216, 20);
            responsableTxt.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 130);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 5;
            label1.Text = "Responsável pelo salvamento";
            // 
            // idTxt
            // 
            idTxt.BackColor = Color.FromArgb(250, 251, 253);
            idTxt.BorderStyle = BorderStyle.None;
            idTxt.Font = new Font("MS UI Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idTxt.ForeColor = SystemColors.WindowText;
            idTxt.Location = new Point(18, 101);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(216, 20);
            idTxt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 78);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // AlterarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(dataGrid);
            Controls.Add(panel1);
            Controls.Add(primeiroBtn);
            Controls.Add(anteriorBtn);
            Controls.Add(proximoBtn);
            Controls.Add(ultimoBtn);
            Controls.Add(leftMenu);
            Controls.Add(windowTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AlterarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlterarForm";
            Load += AlterarForm_Load;
            leftMenu.ResumeLayout(false);
            windowTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeWindowBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)openMenu).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button primeiroBtn;
        private Button anteriorBtn;
        private Button proximoBtn;
        private Button ultimoBtn;
        private Panel leftMenu;
        private Button homePageBtn;
        private Button sairBtn;
        private Button consultarBtn;
        private Button alterarBtn;
        private Button excluirBtn;
        private Button inserirBtn;
        private Panel windowTop;
        private PictureBox closeWindowBtn;
        private PictureBox openMenu;
        private Panel panel1;
        private Label label6;
        private Button insertBtn;
        private RadioButton typeFormService;
        private RadioButton typeFormAutoPart;
        private TextBox extraTxt;
        private Label label4;
        private TextBox valueTxt;
        private Label label5;
        private TextBox nameTxt;
        private Label label3;
        private TextBox responsableTxt;
        private Label label1;
        private TextBox idTxt;
        private Label label2;
    private DataGridView dataGrid;
    }
}
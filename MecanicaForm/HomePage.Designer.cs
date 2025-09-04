namespace MecanicaForm
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
            windowTop = new Panel();
            closeWindowBtn = new PictureBox();
            openMenu = new PictureBox();
            leftMenu = new Panel();
            sairBtn = new Button();
            consultarBtn = new Button();
            alterarBtn = new Button();
            excluirBtn = new Button();
            inserirBtn = new Button();
            homePageBtn = new Button();
            contentPanel = new Panel();
            gridRecentes = new DataGridView();
            kpiPanel = new Panel();
            kpiTitle = new Label();
            kpiTotalLabel = new Label();
            kpiPecasLabel = new Label();
            kpiServicosLabel = new Label();
            kpiTotalValorLabel = new Label();
            kpiValorMedioLabel = new Label();
            navPanel = new Panel();
            navFlow = new FlowLayoutPanel();
            ultimoBtn = new Button();
            proximoBtn = new Button();
            anteriorBtn = new Button();
            primeiroBtn = new Button();
            windowTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeWindowBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openMenu).BeginInit();
            leftMenu.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridRecentes).BeginInit();
            kpiPanel.SuspendLayout();
            navPanel.SuspendLayout();
            navFlow.SuspendLayout();
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
            leftMenu.BackColor = Color.FromArgb(54, 57, 63);
            leftMenu.Controls.Add(sairBtn);
            leftMenu.Controls.Add(consultarBtn);
            leftMenu.Controls.Add(alterarBtn);
            leftMenu.Controls.Add(excluirBtn);
            leftMenu.Controls.Add(inserirBtn);
            leftMenu.Controls.Add(homePageBtn);
            leftMenu.Dock = DockStyle.Left;
            leftMenu.Location = new Point(0, 50);
            leftMenu.Name = "leftMenu";
            leftMenu.Size = new Size(258, 661);
            leftMenu.TabIndex = 1;
            leftMenu.Visible = false;
            // 
            // sairBtn
            // 
            sairBtn.BackColor = Color.FromArgb(54, 57, 63);
            sairBtn.Dock = DockStyle.Bottom;
            sairBtn.FlatAppearance.BorderSize = 0;
            sairBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 82);
            sairBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 68, 74);
            sairBtn.FlatStyle = FlatStyle.Flat;
            sairBtn.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            sairBtn.ForeColor = Color.White;
            sairBtn.Location = new Point(0, 605);
            sairBtn.Name = "sairBtn";
            sairBtn.Size = new Size(258, 56);
            sairBtn.TabIndex = 4;
            sairBtn.Text = "SAIR";
            sairBtn.UseVisualStyleBackColor = false;
            sairBtn.Click += sairBtn_Click;
            // 
            // consultarBtn
            // 
            consultarBtn.BackColor = Color.FromArgb(54, 57, 63);
            consultarBtn.Dock = DockStyle.Top;
            consultarBtn.FlatAppearance.BorderSize = 0;
            consultarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 82);
            consultarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 68, 74);
            consultarBtn.FlatStyle = FlatStyle.Flat;
            consultarBtn.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            consultarBtn.ForeColor = Color.White;
            consultarBtn.Location = new Point(0, 224);
            consultarBtn.Name = "consultarBtn";
            consultarBtn.Size = new Size(258, 56);
            consultarBtn.TabIndex = 3;
            consultarBtn.Text = "CONSULTAR";
            consultarBtn.UseVisualStyleBackColor = false;
            consultarBtn.Click += consultarBtn_Click;
            // 
            // alterarBtn
            // 
            alterarBtn.BackColor = Color.FromArgb(54, 57, 63);
            alterarBtn.Dock = DockStyle.Top;
            alterarBtn.FlatAppearance.BorderSize = 0;
            alterarBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 82);
            alterarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 68, 74);
            alterarBtn.FlatStyle = FlatStyle.Flat;
            alterarBtn.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            alterarBtn.ForeColor = Color.White;
            alterarBtn.Location = new Point(0, 168);
            alterarBtn.Name = "alterarBtn";
            alterarBtn.Size = new Size(258, 56);
            alterarBtn.TabIndex = 2;
            alterarBtn.Text = "ALTERAR";
            alterarBtn.UseVisualStyleBackColor = false;
            alterarBtn.Click += alterarBtn_Click;
            // 
            // excluirBtn
            // 
            excluirBtn.BackColor = Color.FromArgb(54, 57, 63);
            excluirBtn.Dock = DockStyle.Top;
            excluirBtn.FlatAppearance.BorderSize = 0;
            excluirBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 82);
            excluirBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 68, 74);
            excluirBtn.FlatStyle = FlatStyle.Flat;
            excluirBtn.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            excluirBtn.ForeColor = Color.White;
            excluirBtn.Location = new Point(0, 112);
            excluirBtn.Name = "excluirBtn";
            excluirBtn.Size = new Size(258, 56);
            excluirBtn.TabIndex = 1;
            excluirBtn.Text = "EXCLUIR";
            excluirBtn.UseVisualStyleBackColor = false;
            excluirBtn.Click += excluirBtn_Click;
            // 
            // inserirBtn
            // 
            inserirBtn.BackColor = Color.FromArgb(54, 57, 63);
            inserirBtn.Dock = DockStyle.Top;
            inserirBtn.FlatAppearance.BorderSize = 0;
            inserirBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 82);
            inserirBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 68, 74);
            inserirBtn.FlatStyle = FlatStyle.Flat;
            inserirBtn.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            inserirBtn.ForeColor = Color.White;
            inserirBtn.Location = new Point(0, 56);
            inserirBtn.Name = "inserirBtn";
            inserirBtn.Size = new Size(258, 56);
            inserirBtn.TabIndex = 0;
            inserirBtn.Text = "INSERIR";
            inserirBtn.UseVisualStyleBackColor = false;
            inserirBtn.Click += inserirBtn_Click;
            // 
            // homePageBtn
            // 
            homePageBtn.BackColor = Color.FromArgb(54, 57, 63);
            homePageBtn.Dock = DockStyle.Top;
            homePageBtn.FlatAppearance.BorderSize = 0;
            homePageBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(72, 76, 82);
            homePageBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 68, 74);
            homePageBtn.FlatStyle = FlatStyle.Flat;
            homePageBtn.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            homePageBtn.ForeColor = Color.White;
            homePageBtn.Location = new Point(0, 0);
            homePageBtn.Name = "homePageBtn";
            homePageBtn.Size = new Size(258, 56);
            homePageBtn.TabIndex = 5;
            homePageBtn.Text = "INÍCIO";
            homePageBtn.UseVisualStyleBackColor = false;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.White;
            contentPanel.Controls.Add(gridRecentes);
            contentPanel.Controls.Add(kpiPanel);
            contentPanel.Controls.Add(navPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(258, 50);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(926, 661);
            contentPanel.TabIndex = 14;
            // 
            // gridRecentes
            // 
            gridRecentes.AllowUserToAddRows = false;
            gridRecentes.AllowUserToDeleteRows = false;
            gridRecentes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gridRecentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridRecentes.BackgroundColor = Color.White;
            gridRecentes.Location = new Point(20, 170);
            gridRecentes.Name = "gridRecentes";
            gridRecentes.ReadOnly = true;
            gridRecentes.RowHeadersVisible = false;
            gridRecentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridRecentes.Size = new Size(886, 438);
            gridRecentes.TabIndex = 15;
            // 
            // kpiPanel
            // 
            kpiPanel.BackColor = Color.White;
            kpiPanel.Controls.Add(kpiTitle);
            kpiPanel.Controls.Add(kpiTotalLabel);
            kpiPanel.Controls.Add(kpiPecasLabel);
            kpiPanel.Controls.Add(kpiServicosLabel);
            kpiPanel.Controls.Add(kpiTotalValorLabel);
            kpiPanel.Controls.Add(kpiValorMedioLabel);
            kpiPanel.Dock = DockStyle.Top;
            kpiPanel.Location = new Point(0, 0);
            kpiPanel.Name = "kpiPanel";
            kpiPanel.Padding = new Padding(20, 16, 20, 8);
            kpiPanel.Size = new Size(926, 130);
            kpiPanel.TabIndex = 16;
            // 
            // kpiTitle
            // 
            kpiTitle.AutoSize = true;
            kpiTitle.Font = new Font("MS UI Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kpiTitle.ForeColor = Color.FromArgb(96, 86, 194);
            kpiTitle.Location = new Point(20, 10);
            kpiTitle.Name = "kpiTitle";
            kpiTitle.Size = new Size(228, 24);
            kpiTitle.TabIndex = 0;
            kpiTitle.Text = "Resumo das Vendas";
            // 
            // kpiTotalLabel
            // 
            kpiTotalLabel.AutoSize = true;
            kpiTotalLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            kpiTotalLabel.Location = new Point(20, 44);
            kpiTotalLabel.Name = "kpiTotalLabel";
            kpiTotalLabel.Size = new Size(152, 20);
            kpiTotalLabel.TabIndex = 1;
            kpiTotalLabel.Text = "Total de Registros: 0";
            // 
            // kpiPecasLabel
            // 
            kpiPecasLabel.AutoSize = true;
            kpiPecasLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            kpiPecasLabel.Location = new Point(20, 72);
            kpiPecasLabel.Name = "kpiPecasLabel";
            kpiPecasLabel.Size = new Size(125, 20);
            kpiPecasLabel.TabIndex = 2;
            kpiPecasLabel.Text = "Total de Peças: 0";
            // 
            // kpiServicosLabel
            // 
            kpiServicosLabel.AutoSize = true;
            kpiServicosLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            kpiServicosLabel.Location = new Point(20, 100);
            kpiServicosLabel.Name = "kpiServicosLabel";
            kpiServicosLabel.Size = new Size(144, 20);
            kpiServicosLabel.TabIndex = 3;
            kpiServicosLabel.Text = "Total de Serviços: 0";
            // 
            // kpiTotalValorLabel
            // 
            kpiTotalValorLabel.AutoSize = true;
            kpiTotalValorLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            kpiTotalValorLabel.Location = new Point(320, 44);
            kpiTotalValorLabel.Name = "kpiTotalValorLabel";
            kpiTotalValorLabel.Size = new Size(146, 20);
            kpiTotalValorLabel.TabIndex = 4;
            kpiTotalValorLabel.Text = "Valor Total: R$ 0,00";
            // 
            // kpiValorMedioLabel
            // 
            kpiValorMedioLabel.AutoSize = true;
            kpiValorMedioLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            kpiValorMedioLabel.Location = new Point(320, 72);
            kpiValorMedioLabel.Name = "kpiValorMedioLabel";
            kpiValorMedioLabel.Size = new Size(155, 20);
            kpiValorMedioLabel.TabIndex = 5;
            kpiValorMedioLabel.Text = "Valor Médio: R$ 0,00";
            // 
            // navPanel
            // 
            navPanel.BackColor = Color.FromArgb(240, 240, 244);
            navPanel.Controls.Add(navFlow);
            navPanel.Dock = DockStyle.Bottom;
            navPanel.Location = new Point(0, 601);
            navPanel.Name = "navPanel";
            navPanel.Padding = new Padding(12, 10, 12, 10);
            navPanel.Size = new Size(926, 60);
            navPanel.TabIndex = 17;
            // 
            // navFlow
            // 
            navFlow.AutoSize = true;
            navFlow.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            navFlow.Controls.Add(ultimoBtn);
            navFlow.Controls.Add(proximoBtn);
            navFlow.Controls.Add(anteriorBtn);
            navFlow.Controls.Add(primeiroBtn);
            navFlow.Dock = DockStyle.Right;
            navFlow.FlowDirection = FlowDirection.RightToLeft;
            navFlow.Location = new Point(410, 10);
            navFlow.Margin = new Padding(0);
            navFlow.Name = "navFlow";
            navFlow.Size = new Size(504, 40);
            navFlow.TabIndex = 0;
            navFlow.WrapContents = false;
            // 
            // ultimoBtn
            // 
            ultimoBtn.BackColor = Color.FromArgb(96, 96, 120);
            ultimoBtn.FlatAppearance.BorderSize = 0;
            ultimoBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            ultimoBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            ultimoBtn.FlatStyle = FlatStyle.Flat;
            ultimoBtn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            ultimoBtn.ForeColor = Color.White;
            ultimoBtn.Location = new Point(384, 0);
            ultimoBtn.Margin = new Padding(6, 0, 0, 0);
            ultimoBtn.Name = "ultimoBtn";
            ultimoBtn.Size = new Size(120, 38);
            ultimoBtn.TabIndex = 0;
            ultimoBtn.Text = "ÚLTIMO";
            ultimoBtn.UseVisualStyleBackColor = false;
            ultimoBtn.Click += ultimoBtn_Click;
            // 
            // proximoBtn
            // 
            proximoBtn.BackColor = Color.FromArgb(96, 96, 120);
            proximoBtn.FlatAppearance.BorderSize = 0;
            proximoBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            proximoBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            proximoBtn.FlatStyle = FlatStyle.Flat;
            proximoBtn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            proximoBtn.ForeColor = Color.White;
            proximoBtn.Location = new Point(258, 0);
            proximoBtn.Margin = new Padding(6, 0, 0, 0);
            proximoBtn.Name = "proximoBtn";
            proximoBtn.Size = new Size(120, 38);
            proximoBtn.TabIndex = 1;
            proximoBtn.Text = "PRÓXIMO";
            proximoBtn.UseVisualStyleBackColor = false;
            proximoBtn.Click += proximoBtn_Click;
            // 
            // anteriorBtn
            // 
            anteriorBtn.BackColor = Color.FromArgb(96, 96, 120);
            anteriorBtn.FlatAppearance.BorderSize = 0;
            anteriorBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            anteriorBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            anteriorBtn.FlatStyle = FlatStyle.Flat;
            anteriorBtn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            anteriorBtn.ForeColor = Color.White;
            anteriorBtn.Location = new Point(132, 0);
            anteriorBtn.Margin = new Padding(6, 0, 0, 0);
            anteriorBtn.Name = "anteriorBtn";
            anteriorBtn.Size = new Size(120, 38);
            anteriorBtn.TabIndex = 2;
            anteriorBtn.Text = "ANTERIOR";
            anteriorBtn.UseVisualStyleBackColor = false;
            anteriorBtn.Click += anteriorBtn_Click;
            // 
            // primeiroBtn
            // 
            primeiroBtn.BackColor = Color.FromArgb(96, 96, 120);
            primeiroBtn.FlatAppearance.BorderSize = 0;
            primeiroBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            primeiroBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            primeiroBtn.FlatStyle = FlatStyle.Flat;
            primeiroBtn.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            primeiroBtn.ForeColor = Color.White;
            primeiroBtn.Location = new Point(6, 0);
            primeiroBtn.Margin = new Padding(6, 0, 0, 0);
            primeiroBtn.Name = "primeiroBtn";
            primeiroBtn.Size = new Size(120, 38);
            primeiroBtn.TabIndex = 3;
            primeiroBtn.Text = "PRIMEIRO";
            primeiroBtn.UseVisualStyleBackColor = false;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(contentPanel);
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
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridRecentes).EndInit();
            kpiPanel.ResumeLayout(false);
            kpiPanel.PerformLayout();
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            navFlow.ResumeLayout(false);
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
    private Panel contentPanel;
    private Label kpiTitle;
    private Label kpiTotalLabel;
    private Label kpiPecasLabel;
    private Label kpiServicosLabel;
    private Label kpiTotalValorLabel;
    private Label kpiValorMedioLabel;
    private DataGridView gridRecentes;
    private Panel navPanel;
    private FlowLayoutPanel navFlow;
    private Button primeiroBtn;
    private Button anteriorBtn;
    private Button proximoBtn;
    private Button ultimoBtn;
    private Panel kpiPanel;
    }
}
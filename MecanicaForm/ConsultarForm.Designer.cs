namespace MecanicaForm
{
    partial class ConsultarForm
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
            dataGrid = new DataGridView();
            tipoLabel = new Label();
            tipoFilter = new ComboBox();
            primeiroBtn = new Button();
            anteriorBtn = new Button();
            proximoBtn = new Button();
            ultimoBtn = new Button();
            leftMenu = new Panel();
            sairBtn = new Button();
            consultarBtn = new Button();
            alterarBtn = new Button();
            excluirBtn = new Button();
            inserirBtn = new Button();
            homePageBtn = new Button();
            windowTop = new Panel();
            closeWindowBtn = new PictureBox();
            openMenu = new PictureBox();
            contentPanel = new Panel();
            navPanel = new Panel();
            navFlow = new FlowLayoutPanel();
            headerPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            leftMenu.SuspendLayout();
            windowTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeWindowBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openMenu).BeginInit();
            contentPanel.SuspendLayout();
            navPanel.SuspendLayout();
            navFlow.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(0, 56);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(1164, 610);
            dataGrid.TabIndex = 20;
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.Location = new Point(20, 20);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new Size(30, 15);
            tipoLabel.TabIndex = 21;
            tipoLabel.Text = "Tipo";
            // 
            // tipoFilter
            // 
            tipoFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            tipoFilter.FormattingEnabled = true;
            tipoFilter.Items.AddRange(new object[] { "Todos", "Peça", "Serviço" });
            tipoFilter.Location = new Point(60, 16);
            tipoFilter.Name = "tipoFilter";
            tipoFilter.Size = new Size(180, 23);
            tipoFilter.TabIndex = 22;
            // 
            // primeiroBtn
            // 
            primeiroBtn.BackColor = Color.FromArgb(96, 96, 120);
            primeiroBtn.FlatAppearance.BorderSize = 0;
            primeiroBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            primeiroBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            primeiroBtn.FlatStyle = FlatStyle.Flat;
            primeiroBtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold);
            primeiroBtn.ForeColor = Color.White;
            primeiroBtn.Location = new Point(56, 0);
            primeiroBtn.Margin = new Padding(8, 0, 0, 0);
            primeiroBtn.Name = "primeiroBtn";
            primeiroBtn.Size = new Size(116, 35);
            primeiroBtn.TabIndex = 19;
            primeiroBtn.Text = "PRIMEIRO";
            primeiroBtn.UseVisualStyleBackColor = false;
            primeiroBtn.Click += primeiroBtn_Click;
            // 
            // anteriorBtn
            // 
            anteriorBtn.BackColor = Color.FromArgb(96, 96, 120);
            anteriorBtn.FlatAppearance.BorderSize = 0;
            anteriorBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            anteriorBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            anteriorBtn.FlatStyle = FlatStyle.Flat;
            anteriorBtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold);
            anteriorBtn.ForeColor = Color.White;
            anteriorBtn.Location = new Point(180, 0);
            anteriorBtn.Margin = new Padding(8, 0, 0, 0);
            anteriorBtn.Name = "anteriorBtn";
            anteriorBtn.Size = new Size(116, 35);
            anteriorBtn.TabIndex = 18;
            anteriorBtn.Text = "ANTERIOR";
            anteriorBtn.UseVisualStyleBackColor = false;
            anteriorBtn.Click += anteriorBtn_Click;
            // 
            // proximoBtn
            // 
            proximoBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            proximoBtn.BackColor = Color.FromArgb(96, 96, 120);
            proximoBtn.FlatAppearance.BorderSize = 0;
            proximoBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            proximoBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            proximoBtn.FlatStyle = FlatStyle.Flat;
            proximoBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            proximoBtn.ForeColor = Color.White;
            proximoBtn.Location = new Point(304, 0);
            proximoBtn.Margin = new Padding(8, 0, 0, 0);
            proximoBtn.Name = "proximoBtn";
            proximoBtn.Size = new Size(124, 45);
            proximoBtn.TabIndex = 17;
            proximoBtn.Text = "PRÓXIMO";
            proximoBtn.UseVisualStyleBackColor = false;
            proximoBtn.Click += proximoBtn_Click;
            // 
            // ultimoBtn
            // 
            ultimoBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ultimoBtn.BackColor = Color.FromArgb(96, 96, 120);
            ultimoBtn.FlatAppearance.BorderSize = 0;
            ultimoBtn.FlatAppearance.MouseDownBackColor = Color.FromArgb(66, 66, 90);
            ultimoBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(96, 86, 194);
            ultimoBtn.FlatStyle = FlatStyle.Flat;
            ultimoBtn.Font = new Font("MS UI Gothic", 15.75F, FontStyle.Bold);
            ultimoBtn.ForeColor = Color.White;
            ultimoBtn.Location = new Point(436, 0);
            ultimoBtn.Margin = new Padding(8, 0, 0, 0);
            ultimoBtn.Name = "ultimoBtn";
            ultimoBtn.Size = new Size(124, 45);
            ultimoBtn.TabIndex = 16;
            ultimoBtn.Text = "ÚLTIMO";
            ultimoBtn.UseVisualStyleBackColor = false;
            ultimoBtn.Click += ultimoBtn_Click;
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
            leftMenu.Location = new Point(0, 50);
            leftMenu.Name = "leftMenu";
            leftMenu.Size = new Size(258, 661);
            leftMenu.TabIndex = 15;
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
            homePageBtn.Click += homePageBtn_Click;
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
            // contentPanel
            // 
            contentPanel.Controls.Add(dataGrid);
            contentPanel.Controls.Add(navPanel);
            contentPanel.Controls.Add(headerPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(0, 0, 20, 0);
            contentPanel.Size = new Size(1184, 711);
            contentPanel.TabIndex = 23;
            // 
            // navPanel
            // 
            navPanel.Controls.Add(navFlow);
            navPanel.Dock = DockStyle.Bottom;
            navPanel.Location = new Point(0, 666);
            navPanel.Name = "navPanel";
            navPanel.Padding = new Padding(0, 10, 0, 0);
            navPanel.Size = new Size(1164, 45);
            navPanel.TabIndex = 21;
            // 
            // navFlow
            // 
            navFlow.Controls.Add(ultimoBtn);
            navFlow.Controls.Add(proximoBtn);
            navFlow.Controls.Add(anteriorBtn);
            navFlow.Controls.Add(primeiroBtn);
            navFlow.Dock = DockStyle.Right;
            navFlow.FlowDirection = FlowDirection.RightToLeft;
            navFlow.Location = new Point(604, 10);
            navFlow.Margin = new Padding(0);
            navFlow.Name = "navFlow";
            navFlow.Size = new Size(560, 35);
            navFlow.TabIndex = 0;
            navFlow.WrapContents = false;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(tipoFilter);
            headerPanel.Controls.Add(tipoLabel);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Padding = new Padding(20, 20, 20, 0);
            headerPanel.Size = new Size(1164, 56);
            headerPanel.TabIndex = 22;
            // 
            // ConsultarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(windowTop);
            Controls.Add(leftMenu);
            Controls.Add(contentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultarForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConsultarForm";
            Load += ConsultarForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            leftMenu.ResumeLayout(false);
            windowTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeWindowBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)openMenu).EndInit();
            contentPanel.ResumeLayout(false);
            navPanel.ResumeLayout(false);
            navFlow.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
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
    private Panel contentPanel;
    private Panel headerPanel;
    private DataGridView dataGrid;
    private ComboBox tipoFilter;
    private Label tipoLabel;
    private Panel navPanel;
    private FlowLayoutPanel navFlow;
    }
}
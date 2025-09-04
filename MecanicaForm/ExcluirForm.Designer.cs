namespace MecanicaForm
{
    partial class ExcluirForm
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
            dataGrid = new DataGridView();
            navPanel = new Panel();
            navFlow = new FlowLayoutPanel();
            ultimoBtn = new Button();
            proximoBtn = new Button();
            anteriorBtn = new Button();
            primeiroBtn = new Button();
            deleteBtn = new Button();
            leftMenu.SuspendLayout();
            windowTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)closeWindowBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)openMenu).BeginInit();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            navPanel.SuspendLayout();
            navFlow.SuspendLayout();
            SuspendLayout();
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
            leftMenu.TabIndex = 17;
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
            windowTop.TabIndex = 16;
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
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Padding = new Padding(20);
            contentPanel.Size = new Size(1184, 711);
            contentPanel.TabIndex = 18;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(20, 20);
            dataGrid.Margin = new Padding(10);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(1144, 626);
            dataGrid.TabIndex = 0;
            // 
            // navPanel
            // 
            navPanel.Controls.Add(navFlow);
            navPanel.Controls.Add(deleteBtn);
            navPanel.Dock = DockStyle.Bottom;
            navPanel.Location = new Point(20, 646);
            navPanel.Name = "navPanel";
            navPanel.Padding = new Padding(0, 10, 0, 0);
            navPanel.Size = new Size(1144, 45);
            navPanel.TabIndex = 2;
            // 
            // navFlow
            // 
            navFlow.Controls.Add(ultimoBtn);
            navFlow.Controls.Add(proximoBtn);
            navFlow.Controls.Add(anteriorBtn);
            navFlow.Controls.Add(primeiroBtn);
            navFlow.Dock = DockStyle.Right;
            navFlow.FlowDirection = FlowDirection.RightToLeft;
            navFlow.Location = new Point(588, 10);
            navFlow.Margin = new Padding(0);
            navFlow.Name = "navFlow";
            navFlow.Size = new Size(556, 35);
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
            ultimoBtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold);
            ultimoBtn.ForeColor = Color.White;
            ultimoBtn.Location = new Point(440, 0);
            ultimoBtn.Margin = new Padding(8, 0, 0, 0);
            ultimoBtn.Name = "ultimoBtn";
            ultimoBtn.Size = new Size(116, 35);
            ultimoBtn.TabIndex = 14;
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
            proximoBtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold);
            proximoBtn.ForeColor = Color.White;
            proximoBtn.Location = new Point(316, 0);
            proximoBtn.Margin = new Padding(8, 0, 0, 0);
            proximoBtn.Name = "proximoBtn";
            proximoBtn.Size = new Size(116, 35);
            proximoBtn.TabIndex = 15;
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
            anteriorBtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold);
            anteriorBtn.ForeColor = Color.White;
            anteriorBtn.Location = new Point(192, 0);
            anteriorBtn.Margin = new Padding(8, 0, 0, 0);
            anteriorBtn.Name = "anteriorBtn";
            anteriorBtn.Size = new Size(116, 35);
            anteriorBtn.TabIndex = 16;
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
            primeiroBtn.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold);
            primeiroBtn.ForeColor = Color.White;
            primeiroBtn.Location = new Point(68, 0);
            primeiroBtn.Margin = new Padding(8, 0, 0, 0);
            primeiroBtn.Name = "primeiroBtn";
            primeiroBtn.Size = new Size(116, 35);
            primeiroBtn.TabIndex = 17;
            primeiroBtn.Text = "PRIMEIRO";
            primeiroBtn.UseVisualStyleBackColor = false;
            primeiroBtn.Click += primeiroBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(200, 60, 60);
            deleteBtn.Dock = DockStyle.Left;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(0, 10);
            deleteBtn.Margin = new Padding(0);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(200, 35);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "EXCLUIR SELECIONADO";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // ExcluirForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(windowTop);
            Controls.Add(leftMenu);
            Controls.Add(contentPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExcluirForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExcluirForm";
            leftMenu.ResumeLayout(false);
            windowTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)closeWindowBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)openMenu).EndInit();
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            navPanel.ResumeLayout(false);
            navFlow.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

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
    private DataGridView dataGrid;
    private Panel navPanel;
    private FlowLayoutPanel navFlow;
    private Button ultimoBtn;
    private Button proximoBtn;
    private Button anteriorBtn;
    private Button primeiroBtn;
    private Button deleteBtn;
    }
}
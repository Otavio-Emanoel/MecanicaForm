namespace MecanicaForm
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            lblLoadForm = new Label();
            pictureBox1 = new PictureBox();
            progressBarInitialize = new ProgressBar();
            loadingText = new Label();
            contentPanel = new Panel();
            heroCard = new Panel();
            titleLabel = new Label();
            subtitleLabel = new Label();
            progressContainer = new Panel();
            progressFill = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contentPanel.SuspendLayout();
            heroCard.SuspendLayout();
            progressContainer.SuspendLayout();
            SuspendLayout();
            // 
            // lblLoadForm
            // 
            lblLoadForm.AutoSize = true;
            lblLoadForm.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoadForm.ForeColor = Color.White;
            lblLoadForm.Location = new Point(24, 180);
            lblLoadForm.Name = "lblLoadForm";
            lblLoadForm.Size = new Size(0, 41);
            lblLoadForm.TabIndex = 0;
            lblLoadForm.Text = "O PROGRAMA ESTÁ INICIANDO...";
            lblLoadForm.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // progressBarInitialize
            // 
            progressBarInitialize.BackColor = Color.Black;
            progressBarInitialize.Dock = DockStyle.Bottom;
            progressBarInitialize.Location = new Point(0, 492);
            progressBarInitialize.MarqueeAnimationSpeed = 200;
            progressBarInitialize.Name = "progressBarInitialize";
            progressBarInitialize.Size = new Size(800, 8);
            progressBarInitialize.Style = ProgressBarStyle.Continuous;
            progressBarInitialize.TabIndex = 2;
            progressBarInitialize.Visible = false;
            // 
            // loadingText
            // 
            loadingText.AutoSize = true;
            loadingText.ForeColor = Color.Gainsboro;
            loadingText.Location = new Point(24, 280);
            loadingText.Name = "loadingText";
            loadingText.Size = new Size(99, 21);
            loadingText.TabIndex = 3;
            loadingText.Text = "Carregando: ";
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(800, 500);
            contentPanel.TabIndex = 4;
            contentPanel.BackColor = Color.Transparent;
            contentPanel.Controls.Add(heroCard);
            // 
            // heroCard
            // 
            heroCard.BackColor = Color.FromArgb(32, 34, 37);
            heroCard.Location = new Point(140, 90);
            heroCard.Name = "heroCard";
            heroCard.Size = new Size(520, 320);
            heroCard.TabIndex = 0;
            heroCard.Controls.Add(progressContainer);
            heroCard.Controls.Add(loadingText);
            heroCard.Controls.Add(subtitleLabel);
            heroCard.Controls.Add(titleLabel);
            heroCard.Controls.Add(pictureBox1);
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.Location = new Point(168, 24);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(243, 37);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Iniciando o app";
            // 
            // subtitleLabel
            // 
            subtitleLabel.AutoSize = true;
            subtitleLabel.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            subtitleLabel.ForeColor = Color.Silver;
            subtitleLabel.Location = new Point(170, 70);
            subtitleLabel.Name = "subtitleLabel";
            subtitleLabel.Size = new Size(266, 20);
            subtitleLabel.TabIndex = 5;
            subtitleLabel.Text = "Preparando tudo para você começar...";
            // 
            // progressContainer
            // 
            progressContainer.BackColor = Color.FromArgb(55, 58, 62);
            progressContainer.Location = new Point(24, 240);
            progressContainer.Name = "progressContainer";
            progressContainer.Size = new Size(472, 12);
            progressContainer.TabIndex = 6;
            progressContainer.Controls.Add(progressFill);
            // 
            // progressFill
            // 
            progressFill.BackColor = Color.FromArgb(0, 122, 204);
            progressFill.Location = new Point(0, 0);
            progressFill.Name = "progressFill";
            progressFill.Size = new Size(0, 12);
            progressFill.TabIndex = 0;
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 500);
            ControlBox = false;
            Controls.Add(contentPanel);
            Controls.Add(progressBarInitialize);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "SplashForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Load += SplashForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contentPanel.ResumeLayout(false);
            heroCard.ResumeLayout(false);
            heroCard.PerformLayout();
            progressContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

    private Label lblLoadForm;
    private PictureBox pictureBox1;
    private ProgressBar progressBarInitialize;
    private Label loadingText;
    private Panel contentPanel;
    private Panel heroCard;
    private Label titleLabel;
    private Label subtitleLabel;
    private Panel progressContainer;
    private Panel progressFill;
    }
}

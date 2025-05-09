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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLoadForm
            // 
            lblLoadForm.AutoSize = true;
            lblLoadForm.Font = new Font("Sitka Small", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoadForm.ForeColor = Color.White;
            lblLoadForm.Location = new Point(128, 376);
            lblLoadForm.Name = "lblLoadForm";
            lblLoadForm.Size = new Size(529, 43);
            lblLoadForm.TabIndex = 0;
            lblLoadForm.Text = "O PROGRAMA ESTÁ INICIANDO...";
            lblLoadForm.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(219, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(346, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // progressBarInitialize
            // 
            progressBarInitialize.BackColor = Color.Black;
            progressBarInitialize.Dock = DockStyle.Bottom;
            progressBarInitialize.Location = new Point(0, 477);
            progressBarInitialize.MarqueeAnimationSpeed = 200;
            progressBarInitialize.Name = "progressBarInitialize";
            progressBarInitialize.Size = new Size(800, 23);
            progressBarInitialize.Style = ProgressBarStyle.Continuous;
            progressBarInitialize.TabIndex = 2;
            // 
            // loadingText
            // 
            loadingText.AutoSize = true;
            loadingText.ForeColor = Color.White;
            loadingText.Location = new Point(12, 453);
            loadingText.Name = "loadingText";
            loadingText.Size = new Size(99, 21);
            loadingText.TabIndex = 3;
            loadingText.Text = "Carregando: ";
            // 
            // SplashForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 500);
            ControlBox = false;
            Controls.Add(loadingText);
            Controls.Add(progressBarInitialize);
            Controls.Add(pictureBox1);
            Controls.Add(lblLoadForm);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLoadForm;
        private PictureBox pictureBox1;
        private ProgressBar progressBarInitialize;
        private Label loadingText;
    }
}

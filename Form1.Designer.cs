namespace CoinsActivity
{
    partial class Form1
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
            openFileDialog1 = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            openImageToolStripMenuItem = new ToolStripMenuItem();
            pbLoaded = new PictureBox();
            pbProcessed = new PictureBox();
            btnProcess = new Button();
            lblTitle = new Label();
            lblCount = new Label();
            lblLegend = new Label();
            lbl5Cent = new Label();
            lbl10Cent = new Label();
            lbl25Cent = new Label();
            lbl1Peso = new Label();
            lbl5Peso = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoaded).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProcessed).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { openImageToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1231, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // openImageToolStripMenuItem
            // 
            openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            openImageToolStripMenuItem.Size = new Size(105, 24);
            openImageToolStripMenuItem.Text = "Open Image";
            openImageToolStripMenuItem.Click += openImageToolStripMenuItem_Click;
            // 
            // pbLoaded
            // 
            pbLoaded.BackColor = SystemColors.ControlDark;
            pbLoaded.Location = new Point(12, 192);
            pbLoaded.Name = "pbLoaded";
            pbLoaded.Size = new Size(500, 500);
            pbLoaded.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLoaded.TabIndex = 1;
            pbLoaded.TabStop = false;
            // 
            // pbProcessed
            // 
            pbProcessed.BackColor = SystemColors.ControlDark;
            pbProcessed.Location = new Point(718, 192);
            pbProcessed.Name = "pbProcessed";
            pbProcessed.Size = new Size(500, 500);
            pbProcessed.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProcessed.TabIndex = 2;
            pbProcessed.TabStop = false;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(725, 710);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(123, 50);
            btnProcess.TabIndex = 3;
            btnProcess.Text = "Count";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.Location = new Point(477, 82);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(264, 46);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "COINS ACTIVITY";
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 20F);
            lblCount.Location = new Point(868, 710);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(256, 46);
            lblCount.TabIndex = 6;
            lblCount.Text = "Total Amount: 0";
            // 
            // lblLegend
            // 
            lblLegend.AutoSize = true;
            lblLegend.Font = new Font("Segoe UI", 20F);
            lblLegend.Location = new Point(518, 198);
            lblLegend.Name = "lblLegend";
            lblLegend.Size = new Size(138, 46);
            lblLegend.TabIndex = 8;
            lblLegend.Text = "Legend:";
            // 
            // lbl5Cent
            // 
            lbl5Cent.AutoSize = true;
            lbl5Cent.Font = new Font("Segoe UI", 14F);
            lbl5Cent.Location = new Point(518, 244);
            lbl5Cent.Name = "lbl5Cent";
            lbl5Cent.Size = new Size(154, 32);
            lbl5Cent.TabIndex = 9;
            lbl5Cent.Text = "Red - 5 cents";
            // 
            // lbl10Cent
            // 
            lbl10Cent.AutoSize = true;
            lbl10Cent.Font = new Font("Segoe UI", 14F);
            lbl10Cent.Location = new Point(518, 276);
            lbl10Cent.Name = "lbl10Cent";
            lbl10Cent.Size = new Size(194, 32);
            lbl10Cent.TabIndex = 10;
            lbl10Cent.Text = "Yellow - 10 cents";
            // 
            // lbl25Cent
            // 
            lbl25Cent.AutoSize = true;
            lbl25Cent.Font = new Font("Segoe UI", 14F);
            lbl25Cent.Location = new Point(518, 308);
            lbl25Cent.Name = "lbl25Cent";
            lbl25Cent.Size = new Size(191, 32);
            lbl25Cent.TabIndex = 11;
            lbl25Cent.Text = "Green - 25 cents";
            // 
            // lbl1Peso
            // 
            lbl1Peso.AutoSize = true;
            lbl1Peso.Font = new Font("Segoe UI", 14F);
            lbl1Peso.Location = new Point(518, 340);
            lbl1Peso.Name = "lbl1Peso";
            lbl1Peso.Size = new Size(156, 32);
            lbl1Peso.TabIndex = 12;
            lbl1Peso.Text = "Blue - 1 peso";
            // 
            // lbl5Peso
            // 
            lbl5Peso.AutoSize = true;
            lbl5Peso.Font = new Font("Segoe UI", 14F);
            lbl5Peso.Location = new Point(518, 372);
            lbl5Peso.Name = "lbl5Peso";
            lbl5Peso.Size = new Size(181, 32);
            lbl5Peso.TabIndex = 13;
            lbl5Peso.Text = "Violet - 5 pesos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 780);
            Controls.Add(lbl5Peso);
            Controls.Add(lbl1Peso);
            Controls.Add(lbl25Cent);
            Controls.Add(lbl10Cent);
            Controls.Add(lbl5Cent);
            Controls.Add(lblLegend);
            Controls.Add(lblCount);
            Controls.Add(lblTitle);
            Controls.Add(btnProcess);
            Controls.Add(pbProcessed);
            Controls.Add(pbLoaded);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Coins Activity";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLoaded).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProcessed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem openImageToolStripMenuItem;
        private PictureBox pbLoaded;
        private PictureBox pbProcessed;
        private Button btnProcess;
        private Label lblTitle;
        private Label lblCount;
        private Label lblLegend;
        private Label lbl5Cent;
        private Label lbl10Cent;
        private Label lbl25Cent;
        private Label lbl1Peso;
        private Label lbl5Peso;
    }
}

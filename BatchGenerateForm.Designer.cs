namespace Math_Problem_Generator_C_Sharp
{
    partial class BatchGenerateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.browseLocation = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.formattingOption2 = new System.Windows.Forms.RadioButton();
            this.formattingOption1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.questionNumber = new System.Windows.Forms.NumericUpDown();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.generateButton = new System.Windows.Forms.Button();
            this.saveLocation = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusLabel2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionNumber)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generated file location";
            // 
            // browseLocation
            // 
            this.browseLocation.Location = new System.Drawing.Point(15, 28);
            this.browseLocation.Name = "browseLocation";
            this.browseLocation.Size = new System.Drawing.Size(306, 20);
            this.browseLocation.TabIndex = 1;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(327, 25);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(15, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 122);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced generating option";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.formattingOption2);
            this.groupBox3.Controls.Add(this.formattingOption1);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 97);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Text Formatting";
            // 
            // formattingOption2
            // 
            this.formattingOption2.AutoSize = true;
            this.formattingOption2.Checked = true;
            this.formattingOption2.Location = new System.Drawing.Point(6, 55);
            this.formattingOption2.Name = "formattingOption2";
            this.formattingOption2.Size = new System.Drawing.Size(256, 30);
            this.formattingOption2.TabIndex = 1;
            this.formattingOption2.TabStop = true;
            this.formattingOption2.Text = "Readable (Ex : 30 + 40 - 50 X 60 : 70 = 27.XXXX\r\n(Easy to read for humans. )";
            this.formattingOption2.UseVisualStyleBackColor = true;
            // 
            // formattingOption1
            // 
            this.formattingOption1.AutoSize = true;
            this.formattingOption1.Location = new System.Drawing.Point(6, 19);
            this.formattingOption1.Name = "formattingOption1";
            this.formattingOption1.Size = new System.Drawing.Size(268, 30);
            this.formattingOption1.TabIndex = 0;
            this.formattingOption1.Text = "Simple. (Ex : 30+40-50*60/70=27.XXXX\r\n(No formatting. Computable with number proc" +
                "essor.)";
            this.formattingOption1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of question problems";
            // 
            // questionNumber
            // 
            this.questionNumber.Location = new System.Drawing.Point(15, 67);
            this.questionNumber.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.questionNumber.Name = "questionNumber";
            this.questionNumber.Size = new System.Drawing.Size(141, 20);
            this.questionNumber.TabIndex = 5;
            this.questionNumber.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 32);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(390, 23);
            this.progressBar.TabIndex = 6;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(142, 296);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(141, 45);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // saveLocation
            // 
            this.saveLocation.Filter = "Standard Text File|*.txt";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.statusLabel2);
            this.groupBox2.Controls.Add(this.progressBar);
            this.groupBox2.Location = new System.Drawing.Point(15, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 69);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Status";
            // 
            // statusLabel2
            // 
            this.statusLabel2.AutoSize = true;
            this.statusLabel2.Location = new System.Drawing.Point(9, 16);
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(41, 13);
            this.statusLabel2.TabIndex = 8;
            this.statusLabel2.Text = "Ready.";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // BatchGenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 354);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.questionNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.browseLocation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BatchGenerateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Generate Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BatchGenerateForm_FormClosed);
            this.Load += new System.EventHandler(this.BatchGenerateForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionNumber)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox browseLocation;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown questionNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton formattingOption2;
        private System.Windows.Forms.RadioButton formattingOption1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.SaveFileDialog saveLocation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label statusLabel2;
    }
}
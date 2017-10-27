namespace Math_Problem_Generator_C_Sharp
{
    partial class quizForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionProblem = new System.Windows.Forms.TextBox();
            this.genButton = new System.Windows.Forms.Button();
            this.resultNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parameterControl = new System.Windows.Forms.GroupBox();
            this.decimalNumbers = new System.Windows.Forms.NumericUpDown();
            this.firstNum1 = new System.Windows.Forms.NumericUpDown();
            this.firstNum2 = new System.Windows.Forms.NumericUpDown();
            this.iterationValue = new System.Windows.Forms.NumericUpDown();
            this.decimalNumberLabel = new System.Windows.Forms.Label();
            this.noDecimalCheckbox = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.resultFrame = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.parameterControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decimalNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationValue)).BeginInit();
            this.resultFrame.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Number Range. (Default is from 1 to 100)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "to";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(6, 16);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(90, 13);
            this.questionLabel.TabIndex = 8;
            this.questionLabel.Text = "Question Problem";
            // 
            // questionProblem
            // 
            this.questionProblem.Location = new System.Drawing.Point(9, 32);
            this.questionProblem.Multiline = true;
            this.questionProblem.Name = "questionProblem";
            this.questionProblem.ReadOnly = true;
            this.questionProblem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.questionProblem.Size = new System.Drawing.Size(295, 90);
            this.questionProblem.TabIndex = 9;
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(13, 366);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(310, 42);
            this.genButton.TabIndex = 10;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // resultNum
            // 
            this.resultNum.Location = new System.Drawing.Point(9, 141);
            this.resultNum.Name = "resultNum";
            this.resultNum.ReadOnly = true;
            this.resultNum.Size = new System.Drawing.Size(295, 20);
            this.resultNum.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Result";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Number of Iteration";
            // 
            // parameterControl
            // 
            this.parameterControl.Controls.Add(this.decimalNumbers);
            this.parameterControl.Controls.Add(this.firstNum1);
            this.parameterControl.Controls.Add(this.firstNum2);
            this.parameterControl.Controls.Add(this.iterationValue);
            this.parameterControl.Controls.Add(this.decimalNumberLabel);
            this.parameterControl.Controls.Add(this.noDecimalCheckbox);
            this.parameterControl.Controls.Add(this.linkLabel1);
            this.parameterControl.Controls.Add(this.label1);
            this.parameterControl.Controls.Add(this.label3);
            this.parameterControl.Controls.Add(this.label2);
            this.parameterControl.Location = new System.Drawing.Point(12, 12);
            this.parameterControl.Name = "parameterControl";
            this.parameterControl.Size = new System.Drawing.Size(311, 175);
            this.parameterControl.TabIndex = 15;
            this.parameterControl.TabStop = false;
            this.parameterControl.Text = "Generate Settings";
            // 
            // decimalNumbers
            // 
            this.decimalNumbers.Enabled = false;
            this.decimalNumbers.Location = new System.Drawing.Point(9, 149);
            this.decimalNumbers.Name = "decimalNumbers";
            this.decimalNumbers.Size = new System.Drawing.Size(295, 20);
            this.decimalNumbers.TabIndex = 22;
            this.decimalNumbers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // firstNum1
            // 
            this.firstNum1.Location = new System.Drawing.Point(9, 32);
            this.firstNum1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstNum1.Name = "firstNum1";
            this.firstNum1.Size = new System.Drawing.Size(129, 20);
            this.firstNum1.TabIndex = 21;
            this.firstNum1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // firstNum2
            // 
            this.firstNum2.Location = new System.Drawing.Point(166, 32);
            this.firstNum2.Name = "firstNum2";
            this.firstNum2.Size = new System.Drawing.Size(139, 20);
            this.firstNum2.TabIndex = 20;
            this.firstNum2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // iterationValue
            // 
            this.iterationValue.Location = new System.Drawing.Point(9, 81);
            this.iterationValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationValue.Name = "iterationValue";
            this.iterationValue.Size = new System.Drawing.Size(296, 20);
            this.iterationValue.TabIndex = 19;
            this.iterationValue.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // decimalNumberLabel
            // 
            this.decimalNumberLabel.AutoSize = true;
            this.decimalNumberLabel.Enabled = false;
            this.decimalNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.decimalNumberLabel.Location = new System.Drawing.Point(6, 133);
            this.decimalNumberLabel.Name = "decimalNumberLabel";
            this.decimalNumberLabel.Size = new System.Drawing.Size(164, 13);
            this.decimalNumberLabel.TabIndex = 17;
            this.decimalNumberLabel.Text = "Number of Decimals (Default is 2)";
            // 
            // noDecimalCheckbox
            // 
            this.noDecimalCheckbox.AutoSize = true;
            this.noDecimalCheckbox.Checked = true;
            this.noDecimalCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noDecimalCheckbox.Location = new System.Drawing.Point(10, 107);
            this.noDecimalCheckbox.Name = "noDecimalCheckbox";
            this.noDecimalCheckbox.Size = new System.Drawing.Size(126, 17);
            this.noDecimalCheckbox.TabIndex = 16;
            this.noDecimalCheckbox.Text = "No Decimal Numbers";
            this.noDecimalCheckbox.UseVisualStyleBackColor = true;
            this.noDecimalCheckbox.CheckedChanged += new System.EventHandler(this.noDecimalCheckbox_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(240, 64);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 13);
            this.linkLabel1.TabIndex = 15;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "What\'s this?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // resultFrame
            // 
            this.resultFrame.Controls.Add(this.resultNum);
            this.resultFrame.Controls.Add(this.questionLabel);
            this.resultFrame.Controls.Add(this.label6);
            this.resultFrame.Controls.Add(this.questionProblem);
            this.resultFrame.Location = new System.Drawing.Point(13, 193);
            this.resultFrame.Name = "resultFrame";
            this.resultFrame.Size = new System.Drawing.Size(310, 167);
            this.resultFrame.TabIndex = 16;
            this.resultFrame.TabStop = false;
            this.resultFrame.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.logBox);
            this.groupBox1.Location = new System.Drawing.Point(329, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 444);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // logBox
            // 
            this.logBox.HideSelection = false;
            this.logBox.Location = new System.Drawing.Point(6, 16);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(250, 422);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 42);
            this.button1.TabIndex = 18;
            this.button1.Text = "Batch Generate to Text File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 42);
            this.button2.TabIndex = 19;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // quizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 465);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultFrame);
            this.Controls.Add(this.parameterControl);
            this.Controls.Add(this.genButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "quizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Math Problem Generator";
            this.Load += new System.EventHandler(this.quizForm_Load);
            this.parameterControl.ResumeLayout(false);
            this.parameterControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decimalNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationValue)).EndInit();
            this.resultFrame.ResumeLayout(false);
            this.resultFrame.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox questionProblem;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.TextBox resultNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox parameterControl;
        private System.Windows.Forms.GroupBox resultFrame;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label decimalNumberLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.CheckBox noDecimalCheckbox;
        public System.Windows.Forms.NumericUpDown iterationValue;
        public System.Windows.Forms.NumericUpDown firstNum1;
        public System.Windows.Forms.NumericUpDown firstNum2;
        public System.Windows.Forms.NumericUpDown decimalNumbers;
        public System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.Button button2;

    }
}


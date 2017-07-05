namespace TroyTrivia.UI.Forms
{
    partial class SettingsForm
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
            this.lblSettingsHeader = new System.Windows.Forms.Label();
            this.lblFirstHalfSegmentCount = new System.Windows.Forms.Label();
            this.lblSecondHalfSegmentCount = new System.Windows.Forms.Label();
            this.lblHalfTimeQuestion = new System.Windows.Forms.Label();
            this.lblFinalQuestion = new System.Windows.Forms.Label();
            this.chkHalftimeQuestion = new System.Windows.Forms.CheckBox();
            this.chkFinalQuestion = new System.Windows.Forms.CheckBox();
            this.txtSegmentCount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFirstHalfPointScale = new System.Windows.Forms.Label();
            this.rdoFirstHalfPointScaleTwo = new System.Windows.Forms.RadioButton();
            this.rdoFirstHalfPointScaleOne = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSecondHalfPointScale = new System.Windows.Forms.Label();
            this.rdoSecondHalfPointScaleTwo = new System.Windows.Forms.RadioButton();
            this.rdoSecondHalfPointScaleOne = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSettingsHeader
            // 
            this.lblSettingsHeader.AutoSize = true;
            this.lblSettingsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsHeader.Location = new System.Drawing.Point(12, 21);
            this.lblSettingsHeader.Name = "lblSettingsHeader";
            this.lblSettingsHeader.Size = new System.Drawing.Size(121, 31);
            this.lblSettingsHeader.TabIndex = 0;
            this.lblSettingsHeader.Text = "Settings";
            // 
            // lblFirstHalfSegmentCount
            // 
            this.lblFirstHalfSegmentCount.AutoSize = true;
            this.lblFirstHalfSegmentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstHalfSegmentCount.Location = new System.Drawing.Point(18, 78);
            this.lblFirstHalfSegmentCount.Name = "lblFirstHalfSegmentCount";
            this.lblFirstHalfSegmentCount.Size = new System.Drawing.Size(124, 13);
            this.lblFirstHalfSegmentCount.TabIndex = 1;
            this.lblFirstHalfSegmentCount.Text = "First Half Segment Count";
            // 
            // lblSecondHalfSegmentCount
            // 
            this.lblSecondHalfSegmentCount.AutoSize = true;
            this.lblSecondHalfSegmentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondHalfSegmentCount.Location = new System.Drawing.Point(18, 191);
            this.lblSecondHalfSegmentCount.Name = "lblSecondHalfSegmentCount";
            this.lblSecondHalfSegmentCount.Size = new System.Drawing.Size(142, 13);
            this.lblSecondHalfSegmentCount.TabIndex = 2;
            this.lblSecondHalfSegmentCount.Text = "Second Half Segment Count";
            // 
            // lblHalfTimeQuestion
            // 
            this.lblHalfTimeQuestion.AutoSize = true;
            this.lblHalfTimeQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHalfTimeQuestion.Location = new System.Drawing.Point(478, 78);
            this.lblHalfTimeQuestion.Name = "lblHalfTimeQuestion";
            this.lblHalfTimeQuestion.Size = new System.Drawing.Size(96, 13);
            this.lblHalfTimeQuestion.TabIndex = 3;
            this.lblHalfTimeQuestion.Text = "Halftime Question?";
            // 
            // lblFinalQuestion
            // 
            this.lblFinalQuestion.AutoSize = true;
            this.lblFinalQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalQuestion.Location = new System.Drawing.Point(478, 191);
            this.lblFinalQuestion.Name = "lblFinalQuestion";
            this.lblFinalQuestion.Size = new System.Drawing.Size(80, 13);
            this.lblFinalQuestion.TabIndex = 4;
            this.lblFinalQuestion.Text = "Final Question?";
            // 
            // chkHalftimeQuestion
            // 
            this.chkHalftimeQuestion.AutoSize = true;
            this.chkHalftimeQuestion.Location = new System.Drawing.Point(514, 102);
            this.chkHalftimeQuestion.Name = "chkHalftimeQuestion";
            this.chkHalftimeQuestion.Size = new System.Drawing.Size(15, 14);
            this.chkHalftimeQuestion.TabIndex = 5;
            this.chkHalftimeQuestion.UseVisualStyleBackColor = true;
            // 
            // chkFinalQuestion
            // 
            this.chkFinalQuestion.AutoSize = true;
            this.chkFinalQuestion.Location = new System.Drawing.Point(514, 216);
            this.chkFinalQuestion.Name = "chkFinalQuestion";
            this.chkFinalQuestion.Size = new System.Drawing.Size(15, 14);
            this.chkFinalQuestion.TabIndex = 6;
            this.chkFinalQuestion.UseVisualStyleBackColor = true;
            // 
            // txtSegmentCount
            // 
            this.txtSegmentCount.Location = new System.Drawing.Point(21, 102);
            this.txtSegmentCount.Name = "txtSegmentCount";
            this.txtSegmentCount.Size = new System.Drawing.Size(51, 20);
            this.txtSegmentCount.TabIndex = 7;
            this.txtSegmentCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSegmentCount_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(21, 275);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 39);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFirstHalfPointScale);
            this.panel1.Controls.Add(this.rdoFirstHalfPointScaleTwo);
            this.panel1.Controls.Add(this.rdoFirstHalfPointScaleOne);
            this.panel1.Location = new System.Drawing.Point(206, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 16;
            // 
            // lblFirstHalfPointScale
            // 
            this.lblFirstHalfPointScale.AutoSize = true;
            this.lblFirstHalfPointScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstHalfPointScale.Location = new System.Drawing.Point(48, 18);
            this.lblFirstHalfPointScale.Name = "lblFirstHalfPointScale";
            this.lblFirstHalfPointScale.Size = new System.Drawing.Size(105, 13);
            this.lblFirstHalfPointScale.TabIndex = 15;
            this.lblFirstHalfPointScale.Text = "First Half Point Scale";
            // 
            // rdoFirstHalfPointScaleTwo
            // 
            this.rdoFirstHalfPointScaleTwo.AutoSize = true;
            this.rdoFirstHalfPointScaleTwo.Location = new System.Drawing.Point(51, 66);
            this.rdoFirstHalfPointScaleTwo.Name = "rdoFirstHalfPointScaleTwo";
            this.rdoFirstHalfPointScaleTwo.Size = new System.Drawing.Size(55, 17);
            this.rdoFirstHalfPointScaleTwo.TabIndex = 14;
            this.rdoFirstHalfPointScaleTwo.TabStop = true;
            this.rdoFirstHalfPointScaleTwo.Text = "2, 4, 6";
            this.rdoFirstHalfPointScaleTwo.UseVisualStyleBackColor = true;
            // 
            // rdoFirstHalfPointScaleOne
            // 
            this.rdoFirstHalfPointScaleOne.AutoSize = true;
            this.rdoFirstHalfPointScaleOne.Location = new System.Drawing.Point(51, 43);
            this.rdoFirstHalfPointScaleOne.Name = "rdoFirstHalfPointScaleOne";
            this.rdoFirstHalfPointScaleOne.Size = new System.Drawing.Size(55, 17);
            this.rdoFirstHalfPointScaleOne.TabIndex = 13;
            this.rdoFirstHalfPointScaleOne.TabStop = true;
            this.rdoFirstHalfPointScaleOne.Text = "1, 3, 5";
            this.rdoFirstHalfPointScaleOne.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSecondHalfPointScale);
            this.panel2.Controls.Add(this.rdoSecondHalfPointScaleTwo);
            this.panel2.Controls.Add(this.rdoSecondHalfPointScaleOne);
            this.panel2.Location = new System.Drawing.Point(206, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 17;
            // 
            // lblSecondHalfPointScale
            // 
            this.lblSecondHalfPointScale.AutoSize = true;
            this.lblSecondHalfPointScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondHalfPointScale.Location = new System.Drawing.Point(39, 18);
            this.lblSecondHalfPointScale.Name = "lblSecondHalfPointScale";
            this.lblSecondHalfPointScale.Size = new System.Drawing.Size(123, 13);
            this.lblSecondHalfPointScale.TabIndex = 18;
            this.lblSecondHalfPointScale.Text = "Second Half Point Scale";
            // 
            // rdoSecondHalfPointScaleTwo
            // 
            this.rdoSecondHalfPointScaleTwo.AutoSize = true;
            this.rdoSecondHalfPointScaleTwo.Location = new System.Drawing.Point(42, 66);
            this.rdoSecondHalfPointScaleTwo.Name = "rdoSecondHalfPointScaleTwo";
            this.rdoSecondHalfPointScaleTwo.Size = new System.Drawing.Size(55, 17);
            this.rdoSecondHalfPointScaleTwo.TabIndex = 17;
            this.rdoSecondHalfPointScaleTwo.TabStop = true;
            this.rdoSecondHalfPointScaleTwo.Text = "2, 4, 6";
            this.rdoSecondHalfPointScaleTwo.UseVisualStyleBackColor = true;
            // 
            // rdoSecondHalfPointScaleOne
            // 
            this.rdoSecondHalfPointScaleOne.AutoSize = true;
            this.rdoSecondHalfPointScaleOne.Location = new System.Drawing.Point(42, 43);
            this.rdoSecondHalfPointScaleOne.Name = "rdoSecondHalfPointScaleOne";
            this.rdoSecondHalfPointScaleOne.Size = new System.Drawing.Size(55, 17);
            this.rdoSecondHalfPointScaleOne.TabIndex = 16;
            this.rdoSecondHalfPointScaleOne.TabStop = true;
            this.rdoSecondHalfPointScaleOne.Text = "1, 3, 5";
            this.rdoSecondHalfPointScaleOne.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 335);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSegmentCount);
            this.Controls.Add(this.chkFinalQuestion);
            this.Controls.Add(this.chkHalftimeQuestion);
            this.Controls.Add(this.lblFinalQuestion);
            this.Controls.Add(this.lblHalfTimeQuestion);
            this.Controls.Add(this.lblSecondHalfSegmentCount);
            this.Controls.Add(this.lblFirstHalfSegmentCount);
            this.Controls.Add(this.lblSettingsHeader);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSettingsHeader;
        private System.Windows.Forms.Label lblFirstHalfSegmentCount;
        private System.Windows.Forms.Label lblSecondHalfSegmentCount;
        private System.Windows.Forms.Label lblHalfTimeQuestion;
        private System.Windows.Forms.Label lblFinalQuestion;
        private System.Windows.Forms.CheckBox chkHalftimeQuestion;
        private System.Windows.Forms.CheckBox chkFinalQuestion;
        private System.Windows.Forms.TextBox txtSegmentCount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFirstHalfPointScale;
        private System.Windows.Forms.RadioButton rdoFirstHalfPointScaleTwo;
        private System.Windows.Forms.RadioButton rdoFirstHalfPointScaleOne;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSecondHalfPointScale;
        private System.Windows.Forms.RadioButton rdoSecondHalfPointScaleTwo;
        private System.Windows.Forms.RadioButton rdoSecondHalfPointScaleOne;
    }
}
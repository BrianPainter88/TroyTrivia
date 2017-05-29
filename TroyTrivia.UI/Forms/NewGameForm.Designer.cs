namespace TroyTrivia.UI.Forms
{
    partial class NewGameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewGameForm));
            this.cmbDifficulty = new System.Windows.Forms.ComboBox();
            this.lblQuestionDifficulty = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnGenerateRandomQuestion = new System.Windows.Forms.Button();
            this.rchQuestion = new System.Windows.Forms.RichTextBox();
            this.rchAnswer = new System.Windows.Forms.RichTextBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.lblQuestionCount = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDifficulty
            // 
            this.cmbDifficulty.FormattingEnabled = true;
            this.cmbDifficulty.Location = new System.Drawing.Point(77, 53);
            this.cmbDifficulty.Name = "cmbDifficulty";
            this.cmbDifficulty.Size = new System.Drawing.Size(121, 21);
            this.cmbDifficulty.TabIndex = 0;
            // 
            // lblQuestionDifficulty
            // 
            this.lblQuestionDifficulty.AutoSize = true;
            this.lblQuestionDifficulty.Location = new System.Drawing.Point(24, 56);
            this.lblQuestionDifficulty.Name = "lblQuestionDifficulty";
            this.lblQuestionDifficulty.Size = new System.Drawing.Size(50, 13);
            this.lblQuestionDifficulty.TabIndex = 1;
            this.lblQuestionDifficulty.Text = "Difficulty:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(77, 404);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 22);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnGenerateRandomQuestion
            // 
            this.btnGenerateRandomQuestion.Location = new System.Drawing.Point(223, 65);
            this.btnGenerateRandomQuestion.Name = "btnGenerateRandomQuestion";
            this.btnGenerateRandomQuestion.Size = new System.Drawing.Size(161, 22);
            this.btnGenerateRandomQuestion.TabIndex = 3;
            this.btnGenerateRandomQuestion.Text = "Generate Random Question";
            this.btnGenerateRandomQuestion.UseVisualStyleBackColor = true;
            this.btnGenerateRandomQuestion.Click += new System.EventHandler(this.btnGenerateRandomQuestion_Click);
            // 
            // rchQuestion
            // 
            this.rchQuestion.Location = new System.Drawing.Point(77, 161);
            this.rchQuestion.Name = "rchQuestion";
            this.rchQuestion.ReadOnly = true;
            this.rchQuestion.Size = new System.Drawing.Size(428, 81);
            this.rchQuestion.TabIndex = 4;
            this.rchQuestion.Text = "";
            // 
            // rchAnswer
            // 
            this.rchAnswer.Location = new System.Drawing.Point(77, 254);
            this.rchAnswer.Name = "rchAnswer";
            this.rchAnswer.ReadOnly = true;
            this.rchAnswer.Size = new System.Drawing.Size(428, 81);
            this.rchAnswer.TabIndex = 5;
            this.rchAnswer.Text = "";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(24, 161);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(52, 13);
            this.lblQuestion.TabIndex = 6;
            this.lblQuestion.Text = "Question:";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(26, 257);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(45, 13);
            this.lblAnswer.TabIndex = 7;
            this.lblAnswer.Text = "Answer:";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(77, 363);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(121, 22);
            this.btnAddQuestion.TabIndex = 8;
            this.btnAddQuestion.Text = "Select Question";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // lblQuestionCount
            // 
            this.lblQuestionCount.AutoSize = true;
            this.lblQuestionCount.Location = new System.Drawing.Point(259, 368);
            this.lblQuestionCount.Name = "lblQuestionCount";
            this.lblQuestionCount.Size = new System.Drawing.Size(92, 13);
            this.lblQuestionCount.TabIndex = 9;
            this.lblQuestionCount.Text = "Question Count: 0";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(77, 81);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 10;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(40, 83);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(77, 128);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.ReadOnly = true;
            this.txtCategory.Size = new System.Drawing.Size(161, 20);
            this.txtCategory.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Category:";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(24, 15);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(51, 13);
            this.lblLocation.TabIndex = 15;
            this.lblLocation.Text = "Location:";
            // 
            // cmbLocation
            // 
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(77, 12);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(257, 21);
            this.cmbLocation.TabIndex = 14;
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(340, 12);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(101, 23);
            this.btnAddLocation.TabIndex = 16;
            this.btnAddLocation.Text = "Add Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // NewGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 604);
            this.Controls.Add(this.btnAddLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.cmbLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblQuestionCount);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.rchAnswer);
            this.Controls.Add(this.rchQuestion);
            this.Controls.Add(this.btnGenerateRandomQuestion);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblQuestionDifficulty);
            this.Controls.Add(this.cmbDifficulty);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewGameForm";
            this.Text = "New Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDifficulty;
        private System.Windows.Forms.Label lblQuestionDifficulty;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnGenerateRandomQuestion;
        private System.Windows.Forms.RichTextBox rchQuestion;
        private System.Windows.Forms.RichTextBox rchAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Label lblQuestionCount;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Button btnAddLocation;
    }
}
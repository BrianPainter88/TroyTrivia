namespace TroyTrivia.UI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnLoadGame = new System.Windows.Forms.Button();
            this.grdScoreboard = new System.Windows.Forms.DataGridView();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddScore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDecrementScore = new System.Windows.Forms.DataGridViewButtonColumn();
            this.scoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreBoardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlQuestions = new System.Windows.Forms.Panel();
            this.lblAnswerText = new System.Windows.Forms.Label();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.rchAnswerPanel = new System.Windows.Forms.RichTextBox();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rchQuestionPanel = new System.Windows.Forms.RichTextBox();
            this.bndQuestions = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.loadGameFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblLocationTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdScoreboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoardBindingSource)).BeginInit();
            this.pnlQuestions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndQuestions)).BeginInit();
            this.bndQuestions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(30, 13);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(122, 29);
            this.btnCreateGame.TabIndex = 0;
            this.btnCreateGame.Text = "Create Game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.Location = new System.Drawing.Point(185, 13);
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.Size = new System.Drawing.Size(122, 29);
            this.btnLoadGame.TabIndex = 1;
            this.btnLoadGame.Text = "Load Game";
            this.btnLoadGame.UseVisualStyleBackColor = true;
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // grdScoreboard
            // 
            this.grdScoreboard.AllowUserToAddRows = false;
            this.grdScoreboard.AllowUserToDeleteRows = false;
            this.grdScoreboard.AutoGenerateColumns = false;
            this.grdScoreboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdScoreboard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPosition,
            this.colTeamName,
            this.colScore,
            this.colAddScore,
            this.colDecrementScore,
            this.scoresDataGridViewTextBoxColumn});
            this.grdScoreboard.DataSource = this.scoreBoardBindingSource;
            this.grdScoreboard.Location = new System.Drawing.Point(899, 67);
            this.grdScoreboard.Name = "grdScoreboard";
            this.grdScoreboard.ReadOnly = true;
            this.grdScoreboard.RowHeadersVisible = false;
            this.grdScoreboard.Size = new System.Drawing.Size(375, 306);
            this.grdScoreboard.TabIndex = 2;
            this.grdScoreboard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdScoreboard_CellContentClick);
            this.grdScoreboard.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.grdScoreboard_RowPostPaint);
            // 
            // colPosition
            // 
            this.colPosition.FillWeight = 40F;
            this.colPosition.HeaderText = "Pos.";
            this.colPosition.MaxInputLength = 5;
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            this.colPosition.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colPosition.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colPosition.Width = 40;
            // 
            // colTeamName
            // 
            this.colTeamName.DataPropertyName = "Key";
            this.colTeamName.HeaderText = "Team Name";
            this.colTeamName.Name = "colTeamName";
            this.colTeamName.ReadOnly = true;
            this.colTeamName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTeamName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTeamName.Width = 150;
            // 
            // colScore
            // 
            this.colScore.DataPropertyName = "Value";
            this.colScore.HeaderText = "Score";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colAddScore
            // 
            this.colAddScore.HeaderText = "";
            this.colAddScore.Name = "colAddScore";
            this.colAddScore.ReadOnly = true;
            this.colAddScore.Text = "+";
            this.colAddScore.UseColumnTextForButtonValue = true;
            this.colAddScore.Width = 40;
            // 
            // colDecrementScore
            // 
            this.colDecrementScore.HeaderText = "";
            this.colDecrementScore.Name = "colDecrementScore";
            this.colDecrementScore.ReadOnly = true;
            this.colDecrementScore.Text = "-";
            this.colDecrementScore.UseColumnTextForButtonValue = true;
            this.colDecrementScore.Width = 40;
            // 
            // scoresDataGridViewTextBoxColumn
            // 
            this.scoresDataGridViewTextBoxColumn.DataPropertyName = "Scores";
            this.scoresDataGridViewTextBoxColumn.HeaderText = "Scores";
            this.scoresDataGridViewTextBoxColumn.Name = "scoresDataGridViewTextBoxColumn";
            this.scoresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreBoardBindingSource
            // 
            this.scoreBoardBindingSource.DataSource = typeof(TroyTrivia.Business.Entities.ScoreBoard);
            // 
            // pnlQuestions
            // 
            this.pnlQuestions.Controls.Add(this.lblAnswerText);
            this.pnlQuestions.Controls.Add(this.lblQuestionText);
            this.pnlQuestions.Controls.Add(this.rchAnswerPanel);
            this.pnlQuestions.Controls.Add(this.rchQuestionPanel);
            this.pnlQuestions.Controls.Add(this.bndQuestions);
            this.pnlQuestions.Location = new System.Drawing.Point(30, 67);
            this.pnlQuestions.Name = "pnlQuestions";
            this.pnlQuestions.Size = new System.Drawing.Size(863, 306);
            this.pnlQuestions.TabIndex = 3;
            // 
            // lblAnswerText
            // 
            this.lblAnswerText.AutoSize = true;
            this.lblAnswerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswerText.Location = new System.Drawing.Point(431, 29);
            this.lblAnswerText.Name = "lblAnswerText";
            this.lblAnswerText.Size = new System.Drawing.Size(54, 17);
            this.lblAnswerText.TabIndex = 4;
            this.lblAnswerText.Text = "Answer";
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.AutoSize = true;
            this.lblQuestionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(15, 29);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(65, 17);
            this.lblQuestionText.TabIndex = 3;
            this.lblQuestionText.Text = "Question";
            // 
            // rchAnswerPanel
            // 
            this.rchAnswerPanel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "AnswerText", true));
            this.rchAnswerPanel.Location = new System.Drawing.Point(434, 49);
            this.rchAnswerPanel.Name = "rchAnswerPanel";
            this.rchAnswerPanel.Size = new System.Drawing.Size(407, 134);
            this.rchAnswerPanel.TabIndex = 2;
            this.rchAnswerPanel.Text = "";
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataSource = typeof(TroyTrivia.Business.Entities.Question);
            // 
            // rchQuestionPanel
            // 
            this.rchQuestionPanel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "QuestionText", true));
            this.rchQuestionPanel.Location = new System.Drawing.Point(18, 49);
            this.rchQuestionPanel.Name = "rchQuestionPanel";
            this.rchQuestionPanel.Size = new System.Drawing.Size(392, 134);
            this.rchQuestionPanel.TabIndex = 1;
            this.rchQuestionPanel.Text = "";
            // 
            // bndQuestions
            // 
            this.bndQuestions.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bndQuestions.BindingSource = this.questionsBindingSource;
            this.bndQuestions.CountItem = this.bindingNavigatorCountItem;
            this.bndQuestions.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bndQuestions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bndQuestions.Location = new System.Drawing.Point(0, 0);
            this.bndQuestions.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bndQuestions.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bndQuestions.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bndQuestions.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bndQuestions.Name = "bndQuestions";
            this.bndQuestions.PositionItem = this.bindingNavigatorPositionItem;
            this.bndQuestions.Size = new System.Drawing.Size(863, 25);
            this.bndQuestions.TabIndex = 0;
            this.bndQuestions.Text = "Question Navigator";
            this.bndQuestions.RefreshItems += new System.EventHandler(this.bndQuestions_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(899, 32);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(122, 29);
            this.btnAddTeam.TabIndex = 4;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(1027, 37);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(187, 20);
            this.txtTeamName.TabIndex = 5;
            // 
            // loadGameFileDialog
            // 
            this.loadGameFileDialog.DefaultExt = "json";
            this.loadGameFileDialog.FileName = "Game.json";
            // 
            // lblLocationTitle
            // 
            this.lblLocationTitle.AutoSize = true;
            this.lblLocationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocationTitle.Location = new System.Drawing.Point(361, 13);
            this.lblLocationTitle.Name = "lblLocationTitle";
            this.lblLocationTitle.Size = new System.Drawing.Size(154, 31);
            this.lblLocationTitle.TabIndex = 6;
            this.lblLocationTitle.Text = "Troy Trivia";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 396);
            this.Controls.Add(this.lblLocationTitle);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.pnlQuestions);
            this.Controls.Add(this.grdScoreboard);
            this.Controls.Add(this.btnLoadGame);
            this.Controls.Add(this.btnCreateGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Troy Trivia";
            ((System.ComponentModel.ISupportInitialize)(this.grdScoreboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoreBoardBindingSource)).EndInit();
            this.pnlQuestions.ResumeLayout(false);
            this.pnlQuestions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bndQuestions)).EndInit();
            this.bndQuestions.ResumeLayout(false);
            this.bndQuestions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnLoadGame;
        private System.Windows.Forms.DataGridView grdScoreboard;
        private System.Windows.Forms.BindingSource scoreBoardBindingSource;
        private System.Windows.Forms.Panel pnlQuestions;
        private System.Windows.Forms.Label lblAnswerText;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.RichTextBox rchAnswerPanel;
        private System.Windows.Forms.RichTextBox rchQuestionPanel;
        private System.Windows.Forms.BindingNavigator bndQuestions;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.OpenFileDialog loadGameFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
        private System.Windows.Forms.DataGridViewButtonColumn colAddScore;
        private System.Windows.Forms.DataGridViewButtonColumn colDecrementScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblLocationTitle;
    }
}


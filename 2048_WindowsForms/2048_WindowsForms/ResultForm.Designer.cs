namespace _2048_WindowsForms
{
    partial class resultForm
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
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.closeResultButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.deliteResults = new System.Windows.Forms.Button();
            this.resultBoard = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightUnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 575);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // closeResultButton
            // 
            this.closeResultButton.Location = new System.Drawing.Point(85, 339);
            this.closeResultButton.Name = "closeResultButton";
            this.closeResultButton.Size = new System.Drawing.Size(198, 102);
            this.closeResultButton.TabIndex = 3;
            this.closeResultButton.Text = "ВЕРНУТЬСЯ В МЕНЮ";
            this.closeResultButton.UseVisualStyleBackColor = true;
            this.closeResultButton.Click += new System.EventHandler(this.outFromResultButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(20, 12);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(103, 13);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Имя пользователя";
            // 
            // deliteResults
            // 
            this.deliteResults.Location = new System.Drawing.Point(85, 75);
            this.deliteResults.Name = "deliteResults";
            this.deliteResults.Size = new System.Drawing.Size(198, 102);
            this.deliteResults.TabIndex = 5;
            this.deliteResults.Text = "Удалить результаты";
            this.deliteResults.UseVisualStyleBackColor = true;
            this.deliteResults.Click += new System.EventHandler(this.deliteResults_Click);
            // 
            // resultBoard
            // 
            this.resultBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultBoard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.RightUnswer});
            this.resultBoard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.resultBoard.Location = new System.Drawing.Point(372, 58);
            this.resultBoard.Margin = new System.Windows.Forms.Padding(2);
            this.resultBoard.Name = "resultBoard";
            this.resultBoard.RowHeadersWidth = 30;
            this.resultBoard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.resultBoard.RowTemplate.Height = 24;
            this.resultBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.resultBoard.Size = new System.Drawing.Size(353, 397);
            this.resultBoard.TabIndex = 6;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Имя";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            // 
            // RightUnswer
            // 
            this.RightUnswer.HeaderText = "Колличество правильных ответов";
            this.RightUnswer.MinimumWidth = 6;
            this.RightUnswer.Name = "RightUnswer";
            // 
            // resultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 575);
            this.Controls.Add(this.resultBoard);
            this.Controls.Add(this.deliteResults);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.closeResultButton);
            this.Controls.Add(this.splitter1);
            this.Name = "resultForm";
            this.Text = "ResultForm";
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button closeResultButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button deliteResults;
        private System.Windows.Forms.DataGridView resultBoard;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightUnswer;
    }
}
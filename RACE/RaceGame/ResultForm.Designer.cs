namespace Race
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
            splitter1 = new Splitter();
            closeResultButton = new Button();
            userNameLabel = new Label();
            deliteResults = new Button();
            resultBoard = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            RightUnswer = new DataGridViewTextBoxColumn();
            score = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            dateLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)resultBoard).BeginInit();
            SuspendLayout();
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Margin = new Padding(4, 5, 4, 5);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(4, 885);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // closeResultButton
            // 
            closeResultButton.Location = new Point(113, 522);
            closeResultButton.Margin = new Padding(4, 5, 4, 5);
            closeResultButton.Name = "closeResultButton";
            closeResultButton.Size = new Size(264, 157);
            closeResultButton.TabIndex = 3;
            closeResultButton.Text = "ВЕРНУТЬСЯ В МЕНЮ";
            closeResultButton.UseVisualStyleBackColor = true;
            closeResultButton.Click += outFromResultButton_Click;
            // 
            // userLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(27, 18);
            userNameLabel.Name = "userLabel";
            userNameLabel.Size = new Size(139, 20);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "Имя пользователя";
            // 
            // deliteResults
            // 
            deliteResults.Location = new Point(113, 115);
            deliteResults.Margin = new Padding(4, 5, 4, 5);
            deliteResults.Name = "deliteResults";
            deliteResults.Size = new Size(264, 157);
            deliteResults.TabIndex = 5;
            deliteResults.Text = "Удалить результаты";
            deliteResults.UseVisualStyleBackColor = true;
            deliteResults.Click += deliteResults_Click;
            // 
            // resultBoard
            // 
            resultBoard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            resultBoard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            resultBoard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultBoard.Columns.AddRange(new DataGridViewColumn[] { UserName, RightUnswer, score, Date });
            resultBoard.EditMode = DataGridViewEditMode.EditOnKeystroke;
            resultBoard.Location = new Point(420, 90);
            resultBoard.Name = "resultBoard";
            resultBoard.RowHeadersWidth = 30;
            resultBoard.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            resultBoard.RowTemplate.Height = 24;
            resultBoard.SelectionMode = DataGridViewSelectionMode.CellSelect;
            resultBoard.Size = new Size(606, 610);
            resultBoard.TabIndex = 6;
            // 
            // UserName
            // 
            UserName.HeaderText = "Имя";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            // 
            // RightUnswer
            // 
            RightUnswer.HeaderText = "Coins";
            RightUnswer.MinimumWidth = 6;
            RightUnswer.Name = "RightUnswer";
            // 
            // score
            // 
            score.HeaderText = "Score";
            score.MinimumWidth = 6;
            score.Name = "score";
            // 
            // Date
            // 
            Date.HeaderText = "Date/Time";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new Point(908, 29);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(39, 20);
            dateLabel.TabIndex = 7;
            dateLabel.Text = "date";
            // 
            // resultForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 885);
            Controls.Add(dateLabel);
            Controls.Add(resultBoard);
            Controls.Add(deliteResults);
            Controls.Add(userNameLabel);
            Controls.Add(closeResultButton);
            Controls.Add(splitter1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "resultForm";
            Text = "ResultForm";
            Load += ResultForm_Load;
            ((System.ComponentModel.ISupportInitialize)resultBoard).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button closeResultButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button deliteResults;
        private System.Windows.Forms.DataGridView resultBoard;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn RightUnswer;
        private DataGridViewTextBoxColumn score;
        private DataGridViewTextBoxColumn Date;
        private Label dateLabel;
    }
}
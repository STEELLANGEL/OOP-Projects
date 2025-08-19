namespace WinForm_GeniyIdiot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(resultForm));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.closeResultButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.deliteResults = new System.Windows.Forms.Button();
            this.resultBoard = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightUnswer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 708);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // closeResultButton
            // 
            this.closeResultButton.Location = new System.Drawing.Point(113, 417);
            this.closeResultButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeResultButton.Name = "closeResultButton";
            this.closeResultButton.Size = new System.Drawing.Size(264, 125);
            this.closeResultButton.TabIndex = 3;
            this.closeResultButton.Text = "ВЕРНУТЬСЯ В МЕНЮ";
            this.closeResultButton.UseVisualStyleBackColor = true;
            this.closeResultButton.Click += new System.EventHandler(this.outFromResultButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(27, 15);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(129, 16);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "Имя пользователя";
            // 
            // deliteResults
            // 
            this.deliteResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deliteResults.Location = new System.Drawing.Point(113, 231);
            this.deliteResults.Margin = new System.Windows.Forms.Padding(4);
            this.deliteResults.Name = "deliteResults";
            this.deliteResults.Size = new System.Drawing.Size(264, 118);
            this.deliteResults.TabIndex = 5;
            this.deliteResults.Text = "Удалить результаты";
            this.deliteResults.UseVisualStyleBackColor = true;
            this.deliteResults.Click += new System.EventHandler(this.deliteResults_Click);
            // 
            // resultBoard
            // 
            this.resultBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.RightUnswer,
            this.Diagnose});
            this.resultBoard.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.resultBoard.Location = new System.Drawing.Point(447, 44);
            this.resultBoard.Name = "resultBoard";
            this.resultBoard.RowHeadersWidth = 30;
            this.resultBoard.RowTemplate.Height = 24;
            this.resultBoard.Size = new System.Drawing.Size(549, 498);
            this.resultBoard.TabIndex = 6;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Имя";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // RightUnswer
            // 
            this.RightUnswer.HeaderText = "Колличество правильных ответов";
            this.RightUnswer.MinimumWidth = 6;
            this.RightUnswer.Name = "RightUnswer";
            this.RightUnswer.Width = 125;
            // 
            // Diagnose
            // 
            this.Diagnose.HeaderText = "Диагнос";
            this.Diagnose.MinimumWidth = 6;
            this.Diagnose.Name = "Diagnose";
            this.Diagnose.Width = 125;
            // 
            // resultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1064, 708);
            this.Controls.Add(this.resultBoard);
            this.Controls.Add(this.deliteResults);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.closeResultButton);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnose;
    }
}
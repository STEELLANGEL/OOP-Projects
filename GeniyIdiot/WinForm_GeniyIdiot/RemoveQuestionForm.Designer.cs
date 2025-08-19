namespace WinForm_GeniyIdiot
{
    partial class removeQuestionForm
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.textNumberLabel = new System.Windows.Forms.Label();
            this.outButton = new System.Windows.Forms.Button();
            this.showAllQuestion = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(10, 11);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(105, 13);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Имя Пользователя";
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(27, 263);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(151, 93);
            this.removeButton.TabIndex = 2;
            this.removeButton.Text = "УДАЛИТЬ ВОПРОС";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeQuestionButton_Click);
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(214, 311);
            this.inputNumber.Margin = new System.Windows.Forms.Padding(2);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(156, 20);
            this.inputNumber.TabIndex = 3;
            // 
            // textNumberLabel
            // 
            this.textNumberLabel.AutoSize = true;
            this.textNumberLabel.Location = new System.Drawing.Point(212, 271);
            this.textNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.textNumberLabel.Name = "textNumberLabel";
            this.textNumberLabel.Size = new System.Drawing.Size(164, 13);
            this.textNumberLabel.TabIndex = 4;
            this.textNumberLabel.Text = "ВЫБЕРИТЕ НОМЕР ВОПРОСА";
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(412, 263);
            this.outButton.Margin = new System.Windows.Forms.Padding(2);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(147, 93);
            this.outButton.TabIndex = 5;
            this.outButton.Text = "ВЫЙТИ В МЕНЮ";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.outFromRemoveButton_Click);
            // 
            // showAllQuestion
            // 
            this.showAllQuestion.Location = new System.Drawing.Point(12, 31);
            this.showAllQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.showAllQuestion.Name = "showAllQuestion";
            this.showAllQuestion.Size = new System.Drawing.Size(580, 210);
            this.showAllQuestion.TabIndex = 6;
            this.showAllQuestion.Text = "";
            // 
            // removeQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.showAllQuestion);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.textNumberLabel);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.userNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "removeQuestionForm";
            this.Text = "RemoveQuestionForm";
            this.Load += new System.EventHandler(this.removeQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.Label textNumberLabel;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.RichTextBox showAllQuestion;
    }
}
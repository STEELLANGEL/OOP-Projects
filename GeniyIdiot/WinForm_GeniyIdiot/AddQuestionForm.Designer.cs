namespace WinForm_GeniyIdiot
{
    partial class addQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addQuestionForm));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.inputQuestion = new System.Windows.Forms.TextBox();
            this.inputAnswer = new System.Windows.Forms.TextBox();
            this.addQuestionLabel = new System.Windows.Forms.Label();
            this.addAnswerLabel = new System.Windows.Forms.Label();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(25, 25);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(129, 16);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Имя пользователя";
            // 
            // inputQuestion
            // 
            this.inputQuestion.Location = new System.Drawing.Point(187, 130);
            this.inputQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputQuestion.Name = "inputQuestion";
            this.inputQuestion.Size = new System.Drawing.Size(409, 22);
            this.inputQuestion.TabIndex = 1;
            // 
            // inputAnswer
            // 
            this.inputAnswer.Location = new System.Drawing.Point(299, 258);
            this.inputAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputAnswer.Name = "inputAnswer";
            this.inputAnswer.Size = new System.Drawing.Size(189, 22);
            this.inputAnswer.TabIndex = 2;
            // 
            // addQuestionLabel
            // 
            this.addQuestionLabel.AutoSize = true;
            this.addQuestionLabel.Location = new System.Drawing.Point(293, 78);
            this.addQuestionLabel.Name = "addQuestionLabel";
            this.addQuestionLabel.Size = new System.Drawing.Size(193, 16);
            this.addQuestionLabel.TabIndex = 3;
            this.addQuestionLabel.Text = "ВВЕДИТЕ ТЕКСТ ВОПРОСА";
            // 
            // addAnswerLabel
            // 
            this.addAnswerLabel.AutoSize = true;
            this.addAnswerLabel.Location = new System.Drawing.Point(325, 194);
            this.addAnswerLabel.Name = "addAnswerLabel";
            this.addAnswerLabel.Size = new System.Drawing.Size(126, 16);
            this.addAnswerLabel.TabIndex = 4;
            this.addAnswerLabel.Text = "ВВЕДИТЕ ОТВЕТ";
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addQuestionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("addQuestionButton.Image")));
            this.addQuestionButton.Location = new System.Drawing.Point(39, 334);
            this.addQuestionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(325, 178);
            this.addQuestionButton.TabIndex = 5;
            this.addQuestionButton.UseVisualStyleBackColor = false;
            this.addQuestionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(492, 334);
            this.outButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(259, 174);
            this.outButton.TabIndex = 6;
            this.outButton.Text = "Выйти в МЕНЮ";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.offAddQuestionButton_Click);
            // 
            // addQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 562);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.addAnswerLabel);
            this.Controls.Add(this.addQuestionLabel);
            this.Controls.Add(this.inputAnswer);
            this.Controls.Add(this.inputQuestion);
            this.Controls.Add(this.userNameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "addQuestionForm";
            this.Text = "AddQuestionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox inputQuestion;
        private System.Windows.Forms.TextBox inputAnswer;
        private System.Windows.Forms.Label addQuestionLabel;
        private System.Windows.Forms.Label addAnswerLabel;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.Button outButton;
    }
}
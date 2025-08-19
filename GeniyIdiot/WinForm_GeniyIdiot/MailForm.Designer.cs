namespace WinForm_GeniyIdiot
{
    partial class mailForm
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
            this.sendMailButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.outButton = new System.Windows.Forms.Button();
            this.insertUserMail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sendMailButton
            // 
            this.sendMailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendMailButton.Location = new System.Drawing.Point(91, 207);
            this.sendMailButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sendMailButton.Name = "sendMailButton";
            this.sendMailButton.Size = new System.Drawing.Size(267, 119);
            this.sendMailButton.TabIndex = 0;
            this.sendMailButton.Text = "ОТПРАВИТЬ";
            this.sendMailButton.UseVisualStyleBackColor = true;
            this.sendMailButton.Click += new System.EventHandler(this.sendMailButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(129, 16);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Имя пользователя";
            // 
            // outButton
            // 
            this.outButton.Location = new System.Drawing.Point(488, 223);
            this.outButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(177, 95);
            this.outButton.TabIndex = 2;
            this.outButton.Text = "ВЕРНУТЬСЯ в МЕНЮ";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.outFromMaleButton_Click);
            // 
            // insertUserMail
            // 
            this.insertUserMail.Location = new System.Drawing.Point(265, 85);
            this.insertUserMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertUserMail.Name = "insertUserMail";
            this.insertUserMail.Size = new System.Drawing.Size(295, 22);
            this.insertUserMail.TabIndex = 3;
            // 
            // mailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.insertUserMail);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.sendMailButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "mailForm";
            this.Text = "MailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMailButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.TextBox insertUserMail;
    }
}
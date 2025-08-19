namespace WinForm_GeniyIdiot
{
    partial class UserNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserNameForm));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.getNameButton = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.hellowLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(302, 101);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(164, 24);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Как Вас зовут ?";
            // 
            // getNameButton
            // 
            this.getNameButton.Image = ((System.Drawing.Image)(resources.GetObject("getNameButton.Image")));
            this.getNameButton.Location = new System.Drawing.Point(204, 223);
            this.getNameButton.Name = "getNameButton";
            this.getNameButton.Size = new System.Drawing.Size(360, 201);
            this.getNameButton.TabIndex = 1;
            this.getNameButton.UseVisualStyleBackColor = true;
            this.getNameButton.Click += new System.EventHandler(this.getUserNameButton_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(253, 157);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(252, 20);
            this.inputName.TabIndex = 2;
            // 
            // hellowLabel
            // 
            this.hellowLabel.AutoSize = true;
            this.hellowLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hellowLabel.Location = new System.Drawing.Point(100, 41);
            this.hellowLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hellowLabel.Name = "hellowLabel";
            this.hellowLabel.Size = new System.Drawing.Size(654, 31);
            this.hellowLabel.TabIndex = 3;
            this.hellowLabel.Text = "ПРИВЕТСТВУЕМ ВАС В ИГРЕ ГЕНИЙ -ИДИОТ";
            // 
            // UserNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hellowLabel);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.getNameButton);
            this.Controls.Add(this.userNameLabel);
            this.Name = "UserNameForm";
            this.Text = "UserName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button getNameButton;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label hellowLabel;
    }
}
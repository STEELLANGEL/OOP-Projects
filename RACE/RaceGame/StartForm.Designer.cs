namespace Race
{
    partial class startForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startForm));
            userNameLabel = new Label();
            getNameButton = new Button();
            inputName = new TextBox();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLabel.Location = new Point(169, 66);
            userNameLabel.Margin = new Padding(4, 0, 4, 0);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(203, 29);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Как Вас зовут ?";
            // 
            // getNameButton
            // 
            getNameButton.Image = (Image)resources.GetObject("getNameButton.Image");
            getNameButton.Location = new Point(94, 212);
            getNameButton.Margin = new Padding(4, 5, 4, 5);
            getNameButton.Name = "getNameButton";
            getNameButton.Size = new Size(361, 240);
            getNameButton.TabIndex = 1;
            getNameButton.UseVisualStyleBackColor = true;
            getNameButton.Click += getUserNameButton_Click;
            // 
            // inputName
            // 
            inputName.Location = new Point(105, 137);
            inputName.Margin = new Padding(4, 5, 4, 5);
            inputName.Name = "inputName";
            inputName.Size = new Size(335, 27);
            inputName.TabIndex = 2;
            // 
            // startForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 482);
            Controls.Add(inputName);
            Controls.Add(getNameButton);
            Controls.Add(userNameLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "startForm";
            Text = "UserName";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button getNameButton;
        public System.Windows.Forms.TextBox inputName;
    }
}
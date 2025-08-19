namespace WinForm_GeniyIdiot
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.showResultsButton = new System.Windows.Forms.Button();
            this.endAppButton = new System.Windows.Forms.Button();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.sendResultMailButton = new System.Windows.Forms.Button();
            this.startTestButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.removeQuestionButton = new System.Windows.Forms.Button();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.welkomeLabel = new System.Windows.Forms.Label();
            this.reLoadAppButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showResultsButton
            // 
            this.showResultsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showResultsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.showResultsButton.Image = ((System.Drawing.Image)(resources.GetObject("showResultsButton.Image")));
            this.showResultsButton.Location = new System.Drawing.Point(122, 52);
            this.showResultsButton.Name = "showResultsButton";
            this.showResultsButton.Size = new System.Drawing.Size(220, 78);
            this.showResultsButton.TabIndex = 1;
            this.showResultsButton.Text = "Просмотреть результыты";
            this.showResultsButton.UseVisualStyleBackColor = true;
            this.showResultsButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // endAppButton
            // 
            this.endAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.endAppButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.endAppButton.Image = ((System.Drawing.Image)(resources.GetObject("endAppButton.Image")));
            this.endAppButton.Location = new System.Drawing.Point(460, 387);
            this.endAppButton.Name = "endAppButton";
            this.endAppButton.Size = new System.Drawing.Size(130, 134);
            this.endAppButton.TabIndex = 2;
            this.endAppButton.UseVisualStyleBackColor = true;
            this.endAppButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addQuestionButton.ForeColor = System.Drawing.SystemColors.Window;
            this.addQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("addQuestionButton.Image")));
            this.addQuestionButton.Location = new System.Drawing.Point(122, 223);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(220, 84);
            this.addQuestionButton.TabIndex = 3;
            this.addQuestionButton.Text = "ДОБАВИТЬ ВОПРОС";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // sendResultMailButton
            // 
            this.sendResultMailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendResultMailButton.ForeColor = System.Drawing.SystemColors.Window;
            this.sendResultMailButton.Image = ((System.Drawing.Image)(resources.GetObject("sendResultMailButton.Image")));
            this.sendResultMailButton.Location = new System.Drawing.Point(525, 223);
            this.sendResultMailButton.Name = "sendResultMailButton";
            this.sendResultMailButton.Size = new System.Drawing.Size(148, 86);
            this.sendResultMailButton.TabIndex = 4;
            this.sendResultMailButton.Text = "MAIL";
            this.sendResultMailButton.UseVisualStyleBackColor = true;
            this.sendResultMailButton.Click += new System.EventHandler(this.sendResultMailButton_Click);
            // 
            // startTestButton
            // 
            this.startTestButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.startTestButton.Image = ((System.Drawing.Image)(resources.GetObject("startTestButton.Image")));
            this.startTestButton.Location = new System.Drawing.Point(122, 340);
            this.startTestButton.Name = "startTestButton";
            this.startTestButton.Size = new System.Drawing.Size(229, 224);
            this.startTestButton.TabIndex = 0;
            this.startTestButton.UseVisualStyleBackColor = false;
            this.startTestButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(542, 52);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(169, 20);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "Имя пользователя";
            // 
            // removeQuestionButton
            // 
            this.removeQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeQuestionButton.ForeColor = System.Drawing.SystemColors.Window;
            this.removeQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("removeQuestionButton.Image")));
            this.removeQuestionButton.Location = new System.Drawing.Point(122, 136);
            this.removeQuestionButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeQuestionButton.Name = "removeQuestionButton";
            this.removeQuestionButton.Size = new System.Drawing.Size(220, 82);
            this.removeQuestionButton.TabIndex = 6;
            this.removeQuestionButton.Text = "УДАЛИТЬ ВОПРОС";
            this.removeQuestionButton.UseVisualStyleBackColor = true;
            this.removeQuestionButton.Click += new System.EventHandler(this.removeQuestionButton_Click);
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rulesLabel.Location = new System.Drawing.Point(371, 101);
            this.rulesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(79, 18);
            this.rulesLabel.TabIndex = 7;
            this.rulesLabel.Text = "ПРАВИЛА";
            // 
            // welkomeLabel
            // 
            this.welkomeLabel.AutoSize = true;
            this.welkomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welkomeLabel.Location = new System.Drawing.Point(370, 52);
            this.welkomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welkomeLabel.Name = "welkomeLabel";
            this.welkomeLabel.Size = new System.Drawing.Size(175, 20);
            this.welkomeLabel.TabIndex = 8;
            this.welkomeLabel.Text = "Добро пожаловать,";
            // 
            // reLoadAppButton
            // 
            this.reLoadAppButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.reLoadAppButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reLoadAppButton.BackgroundImage")));
            this.reLoadAppButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.reLoadAppButton.Image = ((System.Drawing.Image)(resources.GetObject("reLoadAppButton.Image")));
            this.reLoadAppButton.Location = new System.Drawing.Point(615, 387);
            this.reLoadAppButton.Margin = new System.Windows.Forms.Padding(2);
            this.reLoadAppButton.Name = "reLoadAppButton";
            this.reLoadAppButton.Size = new System.Drawing.Size(134, 134);
            this.reLoadAppButton.TabIndex = 9;
            this.reLoadAppButton.UseVisualStyleBackColor = false;
            this.reLoadAppButton.Click += new System.EventHandler(this.reLoadTestButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 575);
            this.Controls.Add(this.reLoadAppButton);
            this.Controls.Add(this.welkomeLabel);
            this.Controls.Add(this.rulesLabel);
            this.Controls.Add(this.removeQuestionButton);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.sendResultMailButton);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.endAppButton);
            this.Controls.Add(this.showResultsButton);
            this.Controls.Add(this.startTestButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startTestButton;
        private System.Windows.Forms.Button showResultsButton;
        private System.Windows.Forms.Button endAppButton;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.Button sendResultMailButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button removeQuestionButton;
        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Label welkomeLabel;
        private System.Windows.Forms.Button reLoadAppButton;
    }
}
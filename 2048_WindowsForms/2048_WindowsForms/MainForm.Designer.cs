namespace _2048_WindowsForms
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
            this.countLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.escapeTextLabel = new System.Windows.Forms.Label();
            this.bestTextLabel = new System.Windows.Forms.Label();
            this.bestScoreLabel = new System.Windows.Forms.Label();
            this.gameSizeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countLabel.Location = new System.Drawing.Point(22, 30);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(52, 18);
            this.countLabel.TabIndex = 1;
            this.countLabel.Text = "СЧЕТ";
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scoreLabel.Location = new System.Drawing.Point(38, 56);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(17, 18);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(12, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(38, 16);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "ИМЯ";
            // 
            // escapeTextLabel
            // 
            this.escapeTextLabel.AutoSize = true;
            this.escapeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escapeTextLabel.Location = new System.Drawing.Point(-4, 94);
            this.escapeTextLabel.Name = "escapeTextLabel";
            this.escapeTextLabel.Size = new System.Drawing.Size(280, 13);
            this.escapeTextLabel.TabIndex = 9;
            this.escapeTextLabel.Text = "Завершить игру -  нажмите клавишу  ESCAPE";
            this.escapeTextLabel.Visible = false;
            // 
            // bestTextLabel
            // 
            this.bestTextLabel.AutoSize = true;
            this.bestTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestTextLabel.Location = new System.Drawing.Point(134, 30);
            this.bestTextLabel.Name = "bestTextLabel";
            this.bestTextLabel.Size = new System.Drawing.Size(80, 18);
            this.bestTextLabel.TabIndex = 11;
            this.bestTextLabel.Text = "ЛУЧШИЙ";
            // 
            // bestScoreLabel
            // 
            this.bestScoreLabel.AutoSize = true;
            this.bestScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bestScoreLabel.Location = new System.Drawing.Point(162, 55);
            this.bestScoreLabel.Name = "bestScoreLabel";
            this.bestScoreLabel.Size = new System.Drawing.Size(35, 18);
            this.bestScoreLabel.TabIndex = 12;
            this.bestScoreLabel.Text = "топ";
            // 
            // gameSizeLabel
            // 
            this.gameSizeLabel.AutoSize = true;
            this.gameSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameSizeLabel.Location = new System.Drawing.Point(65, 9);
            this.gameSizeLabel.Name = "gameSizeLabel";
            this.gameSizeLabel.Size = new System.Drawing.Size(108, 16);
            this.gameSizeLabel.TabIndex = 14;
            this.gameSizeLabel.Text = "ФОРМАТ ПОЛЯ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(813, 586);
            this.Controls.Add(this.gameSizeLabel);
            this.Controls.Add(this.bestScoreLabel);
            this.Controls.Add(this.bestTextLabel);
            this.Controls.Add(this.escapeTextLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.countLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label escapeTextLabel;
        private System.Windows.Forms.Label bestTextLabel;
        public System.Windows.Forms.Label bestScoreLabel;
        private System.Windows.Forms.Label gameSizeLabel;
    }
}


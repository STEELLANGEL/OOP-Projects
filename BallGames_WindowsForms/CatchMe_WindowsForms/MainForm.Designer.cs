namespace CatchMe_WindowsForms
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainLabel = new System.Windows.Forms.Label();
            this.exitpLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.countBallsLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.cathTextLabel = new System.Windows.Forms.Label();
            this.startMenuButton = new System.Windows.Forms.Button();
            this.hitCountScore = new System.Windows.Forms.Label();
            this.hitCountText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(240, 205);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(686, 69);
            this.mainLabel.TabIndex = 14;
            this.mainLabel.Text = "ПОЙМАЙ ШАРИКИ";
            // 
            // exitpLabel
            // 
            this.exitpLabel.AutoSize = true;
            this.exitpLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitpLabel.Location = new System.Drawing.Point(144, 654);
            this.exitpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitpLabel.Name = "exitpLabel";
            this.exitpLabel.Size = new System.Drawing.Size(106, 31);
            this.exitpLabel.TabIndex = 13;
            this.exitpLabel.Text = "ВЫЙТИ";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(915, 654);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(191, 31);
            this.startLabel.TabIndex = 12;
            this.startLabel.Text = "НАЧАТЬ ИГРУ";
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(40, 411);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(276, 239);
            this.exitButton.TabIndex = 10;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startButton
            // 
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(865, 411);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(276, 239);
            this.startButton.TabIndex = 8;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // countBallsLabel
            // 
            this.countBallsLabel.AutoSize = true;
            this.countBallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countBallsLabel.Location = new System.Drawing.Point(376, 39);
            this.countBallsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.countBallsLabel.Name = "countBallsLabel";
            this.countBallsLabel.Size = new System.Drawing.Size(50, 54);
            this.countBallsLabel.TabIndex = 15;
            this.countBallsLabel.Text = "0";
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.restartButton.Image = ((System.Drawing.Image)(resources.GetObject("restartButton.Image")));
            this.restartButton.Location = new System.Drawing.Point(620, 623);
            this.restartButton.Margin = new System.Windows.Forms.Padding(4);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(151, 59);
            this.restartButton.TabIndex = 16;
            this.restartButton.Text = "РЕСТАРТ";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartGameButton);
            // 
            // cathTextLabel
            // 
            this.cathTextLabel.AutoSize = true;
            this.cathTextLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cathTextLabel.Location = new System.Drawing.Point(88, 48);
            this.cathTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cathTextLabel.Name = "cathTextLabel";
            this.cathTextLabel.Size = new System.Drawing.Size(259, 44);
            this.cathTextLabel.TabIndex = 17;
            this.cathTextLabel.Text = "ПОЙМАНО   :";
            // 
            // startMenuButton
            // 
            this.startMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("startMenuButton.Image")));
            this.startMenuButton.Location = new System.Drawing.Point(419, 623);
            this.startMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.startMenuButton.Name = "startMenuButton";
            this.startMenuButton.Size = new System.Drawing.Size(149, 59);
            this.startMenuButton.TabIndex = 18;
            this.startMenuButton.Text = "МЕНЮ";
            this.startMenuButton.UseVisualStyleBackColor = true;
            this.startMenuButton.Click += new System.EventHandler(this.startMebuButton_Click);
            // 
            // hitCountScore
            // 
            this.hitCountScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hitCountScore.Location = new System.Drawing.Point(1024, 42);
            this.hitCountScore.Name = "hitCountScore";
            this.hitCountScore.Size = new System.Drawing.Size(97, 51);
            this.hitCountScore.TabIndex = 19;
            this.hitCountScore.Text = "0";
            // 
            // hitCountText
            // 
            this.hitCountText.AutoSize = true;
            this.hitCountText.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hitCountText.Location = new System.Drawing.Point(710, 48);
            this.hitCountText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hitCountText.Name = "hitCountText";
            this.hitCountText.Size = new System.Drawing.Size(301, 44);
            this.hitCountText.TabIndex = 23;
            this.hitCountText.Text = "ОТСКОЧИЛО   :";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 705);
            this.Controls.Add(this.hitCountText);
            this.Controls.Add(this.hitCountScore);
            this.Controls.Add(this.startMenuButton);
            this.Controls.Add(this.cathTextLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.countBallsLabel);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.exitpLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Label exitpLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label countBallsLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label cathTextLabel;
        private System.Windows.Forms.Button startMenuButton;
        private System.Windows.Forms.Label hitCountScore;
        private System.Windows.Forms.Label hitCountText;
    }
}


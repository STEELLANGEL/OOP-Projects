namespace BillyardBallsWindowsForms
{
    partial class ManeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManeForm));
            this.redLeftLabel = new System.Windows.Forms.Label();
            this.redDownLabel = new System.Windows.Forms.Label();
            this.redTopLabel = new System.Windows.Forms.Label();
            this.redRightLabel = new System.Windows.Forms.Label();
            this.startMenuButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.exitpLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.blueLabelRight = new System.Windows.Forms.Label();
            this.blueLabelTop = new System.Windows.Forms.Label();
            this.blueLabelDown = new System.Windows.Forms.Label();
            this.blueLabelLeft = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redLeftLabel
            // 
            this.redLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redLeftLabel.ForeColor = System.Drawing.Color.Red;
            this.redLeftLabel.Location = new System.Drawing.Point(20, 281);
            this.redLeftLabel.Name = "redLeftLabel";
            this.redLeftLabel.Size = new System.Drawing.Size(44, 41);
            this.redLeftLabel.TabIndex = 0;
            this.redLeftLabel.Text = "0";
            // 
            // redDownLabel
            // 
            this.redDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redDownLabel.ForeColor = System.Drawing.Color.Red;
            this.redDownLabel.Location = new System.Drawing.Point(463, 636);
            this.redDownLabel.Name = "redDownLabel";
            this.redDownLabel.Size = new System.Drawing.Size(44, 45);
            this.redDownLabel.TabIndex = 1;
            this.redDownLabel.Text = "0";
            // 
            // redTopLabel
            // 
            this.redTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redTopLabel.ForeColor = System.Drawing.Color.Red;
            this.redTopLabel.Location = new System.Drawing.Point(463, 9);
            this.redTopLabel.Name = "redTopLabel";
            this.redTopLabel.Size = new System.Drawing.Size(44, 35);
            this.redTopLabel.TabIndex = 2;
            this.redTopLabel.Text = "0";
            // 
            // redRightLabel
            // 
            this.redRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.redRightLabel.ForeColor = System.Drawing.Color.Red;
            this.redRightLabel.Location = new System.Drawing.Point(1050, 278);
            this.redRightLabel.Name = "redRightLabel";
            this.redRightLabel.Size = new System.Drawing.Size(44, 39);
            this.redRightLabel.TabIndex = 3;
            this.redRightLabel.Text = "0";
            // 
            // startMenuButton
            // 
            this.startMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startMenuButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startMenuButton.Image = ((System.Drawing.Image)(resources.GetObject("startMenuButton.Image")));
            this.startMenuButton.Location = new System.Drawing.Point(64, 613);
            this.startMenuButton.Margin = new System.Windows.Forms.Padding(4);
            this.startMenuButton.Name = "startMenuButton";
            this.startMenuButton.Size = new System.Drawing.Size(149, 59);
            this.startMenuButton.TabIndex = 22;
            this.startMenuButton.Text = "МЕНЮ";
            this.startMenuButton.UseVisualStyleBackColor = true;
            this.startMenuButton.Click += new System.EventHandler(this.startMenuButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.restartButton.Image = ((System.Drawing.Image)(resources.GetObject("restartButton.Image")));
            this.restartButton.Location = new System.Drawing.Point(967, 622);
            this.restartButton.Margin = new System.Windows.Forms.Padding(4);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(151, 59);
            this.restartButton.TabIndex = 21;
            this.restartButton.Text = "РЕСТАРТ";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(25, 392);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(276, 239);
            this.exitButton.TabIndex = 20;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startButton
            // 
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(842, 392);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(276, 239);
            this.startButton.TabIndex = 19;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitpLabel
            // 
            this.exitpLabel.AutoSize = true;
            this.exitpLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitpLabel.Location = new System.Drawing.Point(110, 651);
            this.exitpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitpLabel.Name = "exitpLabel";
            this.exitpLabel.Size = new System.Drawing.Size(106, 31);
            this.exitpLabel.TabIndex = 24;
            this.exitpLabel.Text = "ВЫЙТИ";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(903, 651);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(191, 31);
            this.startLabel.TabIndex = 23;
            this.startLabel.Text = "НАЧАТЬ ИГРУ";
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameNameLabel.Location = new System.Drawing.Point(274, 171);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(624, 54);
            this.gameNameLabel.TabIndex = 25;
            this.gameNameLabel.Text = "БИЛЛИАРДНЫЕ ШАРИКИ";
            // 
            // blueLabelRight
            // 
            this.blueLabelRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueLabelRight.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.blueLabelRight.Location = new System.Drawing.Point(1113, 278);
            this.blueLabelRight.Name = "blueLabelRight";
            this.blueLabelRight.Size = new System.Drawing.Size(29, 27);
            this.blueLabelRight.TabIndex = 29;
            this.blueLabelRight.Text = "0";
            // 
            // blueLabelTop
            // 
            this.blueLabelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueLabelTop.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.blueLabelTop.Location = new System.Drawing.Point(646, 9);
            this.blueLabelTop.Name = "blueLabelTop";
            this.blueLabelTop.Size = new System.Drawing.Size(26, 35);
            this.blueLabelTop.TabIndex = 28;
            this.blueLabelTop.Text = "0";
            // 
            // blueLabelDown
            // 
            this.blueLabelDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueLabelDown.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.blueLabelDown.Location = new System.Drawing.Point(637, 636);
            this.blueLabelDown.Name = "blueLabelDown";
            this.blueLabelDown.Size = new System.Drawing.Size(35, 35);
            this.blueLabelDown.TabIndex = 27;
            this.blueLabelDown.Text = "0";
            // 
            // blueLabelLeft
            // 
            this.blueLabelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blueLabelLeft.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.blueLabelLeft.Location = new System.Drawing.Point(91, 281);
            this.blueLabelLeft.Name = "blueLabelLeft";
            this.blueLabelLeft.Size = new System.Drawing.Size(30, 27);
            this.blueLabelLeft.TabIndex = 26;
            this.blueLabelLeft.Text = "0";
            // 
            // ManeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 704);
            this.Controls.Add(this.blueLabelRight);
            this.Controls.Add(this.blueLabelTop);
            this.Controls.Add(this.blueLabelDown);
            this.Controls.Add(this.blueLabelLeft);
            this.Controls.Add(this.gameNameLabel);
            this.Controls.Add(this.exitpLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startMenuButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.redRightLabel);
            this.Controls.Add(this.redTopLabel);
            this.Controls.Add(this.redDownLabel);
            this.Controls.Add(this.redLeftLabel);
            this.Name = "ManeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ManeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label redLeftLabel;
        private System.Windows.Forms.Label redDownLabel;
        private System.Windows.Forms.Label redTopLabel;
        private System.Windows.Forms.Label redRightLabel;
        private System.Windows.Forms.Button startMenuButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label exitpLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Label blueLabelRight;
        private System.Windows.Forms.Label blueLabelTop;
        private System.Windows.Forms.Label blueLabelDown;
        private System.Windows.Forms.Label blueLabelLeft;
    }
}


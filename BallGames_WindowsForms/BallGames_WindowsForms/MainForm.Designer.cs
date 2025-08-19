namespace BallGames_WindowsForms
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
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.catchLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.exitpLabel = new System.Windows.Forms.Label();
            this.mainLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(844, 366);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(276, 239);
            this.startButton.TabIndex = 1;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.randomBallButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Image = ((System.Drawing.Image)(resources.GetObject("stopButton.Image")));
            this.stopButton.Location = new System.Drawing.Point(835, 191);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(276, 239);
            this.stopButton.TabIndex = 2;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(51, 366);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(276, 239);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // catchLabel
            // 
            this.catchLabel.AutoSize = true;
            this.catchLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catchLabel.Location = new System.Drawing.Point(865, 620);
            this.catchLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.catchLabel.Name = "catchLabel";
            this.catchLabel.Size = new System.Drawing.Size(257, 31);
            this.catchLabel.TabIndex = 4;
            this.catchLabel.Text = "ПОЙМАТЬ ШАРИКИ";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(896, 620);
            this.startLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(191, 31);
            this.startLabel.TabIndex = 5;
            this.startLabel.Text = "НАЧАТЬ ИГРУ";
            // 
            // exitpLabel
            // 
            this.exitpLabel.AutoSize = true;
            this.exitpLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitpLabel.Location = new System.Drawing.Point(137, 620);
            this.exitpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitpLabel.Name = "exitpLabel";
            this.exitpLabel.Size = new System.Drawing.Size(106, 31);
            this.exitpLabel.TabIndex = 6;
            this.exitpLabel.Text = "ВЫЙТИ";
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(223, 87);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(686, 69);
            this.mainLabel.TabIndex = 7;
            this.mainLabel.Text = "ПОЙМАЙ ШАРИКИ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1175, 674);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.exitpLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.catchLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label catchLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label exitpLabel;
        private System.Windows.Forms.Label mainLabel;
    }
}


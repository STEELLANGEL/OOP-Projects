namespace _2048_WindowsForms
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.showResultButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.ruleButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.endGameButton = new System.Windows.Forms.Button();
            this.mapSize = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showResultButton
            // 
            this.showResultButton.Location = new System.Drawing.Point(272, 160);
            this.showResultButton.Name = "showResultButton";
            this.showResultButton.Size = new System.Drawing.Size(187, 57);
            this.showResultButton.TabIndex = 18;
            this.showResultButton.Text = "Показать результаты";
            this.showResultButton.UseVisualStyleBackColor = true;
            this.showResultButton.Click += new System.EventHandler(this.showResultButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(29, 230);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(222, 159);
            this.startGameButton.TabIndex = 17;
            this.startGameButton.Text = "НАЧАТЬ ИГРУ";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // ruleButton
            // 
            this.ruleButton.Location = new System.Drawing.Point(272, 47);
            this.ruleButton.Name = "ruleButton";
            this.ruleButton.Size = new System.Drawing.Size(187, 57);
            this.ruleButton.TabIndex = 16;
            this.ruleButton.Text = "ПРАВИЛА ИГРЫ";
            this.ruleButton.UseVisualStyleBackColor = true;
            this.ruleButton.Click += new System.EventHandler(this.ruleButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.White;
            this.restartButton.Location = new System.Drawing.Point(464, 269);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(125, 120);
            this.restartButton.TabIndex = 15;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // endGameButton
            // 
            this.endGameButton.Location = new System.Drawing.Point(609, 269);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(124, 120);
            this.endGameButton.TabIndex = 14;
            this.endGameButton.Text = "END GAME";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click_1);
            // 
            // mapSize
            // 
            this.mapSize.AutoSize = true;
            this.mapSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mapSize.Location = new System.Drawing.Point(64, 123);
            this.mapSize.Name = "mapSize";
            this.mapSize.Size = new System.Drawing.Size(134, 18);
            this.mapSize.TabIndex = 24;
            this.mapSize.Text = "ФОРМАТ ПОЛЯ";
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.BackColor = System.Drawing.Color.Honeydew;
            this.gameName.Cursor = System.Windows.Forms.Cursors.Default;
            this.gameName.Font = new System.Drawing.Font("MS Gothic", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gameName.Location = new System.Drawing.Point(523, 11);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(198, 80);
            this.gameName.TabIndex = 19;
            this.gameName.Text = "2048";
            this.gameName.Click += new System.EventHandler(this.gameName_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(39, 27);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(32, 13);
            this.userNameLabel.TabIndex = 25;
            this.userNameLabel.Text = "ИМЯ";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(758, 411);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.mapSize);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.showResultButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.ruleButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.endGameButton);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showResultButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button ruleButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button endGameButton;
        private System.Windows.Forms.Label mapSize;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label userNameLabel;
    }
}
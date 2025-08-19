namespace FruitNinja_WinForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.count = new System.Windows.Forms.Label();
            this.countSliceText = new System.Windows.Forms.Label();
            this.escTextLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.count.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.count.ForeColor = System.Drawing.Color.White;
            this.count.Location = new System.Drawing.Point(1080, 26);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(31, 32);
            this.count.TabIndex = 0;
            this.count.Text = "0";
            // 
            // countSliceText
            // 
            this.countSliceText.AutoSize = true;
            this.countSliceText.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.countSliceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countSliceText.ForeColor = System.Drawing.Color.White;
            this.countSliceText.Location = new System.Drawing.Point(841, 26);
            this.countSliceText.Name = "countSliceText";
            this.countSliceText.Size = new System.Drawing.Size(196, 32);
            this.countSliceText.TabIndex = 1;
            this.countSliceText.Text = "РАЗРЕЗАНО";
            // 
            // escTextLabel
            // 
            this.escTextLabel.AutoSize = true;
            this.escTextLabel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.escTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.escTextLabel.ForeColor = System.Drawing.Color.White;
            this.escTextLabel.Location = new System.Drawing.Point(350, 646);
            this.escTextLabel.Name = "escTextLabel";
            this.escTextLabel.Size = new System.Drawing.Size(451, 32);
            this.escTextLabel.TabIndex = 2;
            this.escTextLabel.Text = "Для завершения нажмите ESC";
            // 
            // exitButton
            // 
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.Location = new System.Drawing.Point(13, 439);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(276, 239);
            this.exitButton.TabIndex = 22;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // startButton
            // 
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(893, 451);
            this.startButton.Margin = new System.Windows.Forms.Padding(4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(276, 239);
            this.startButton.TabIndex = 21;
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::FruitNinja_WinForms.Properties.Resources.FRUIT;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 703);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 703);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.escTextLabel);
            this.Controls.Add(this.countSliceText);
            this.Controls.Add(this.count);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "FruitNinja";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Label countSliceText;
        private System.Windows.Forms.Label escTextLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


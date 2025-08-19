namespace Race
{
	partial class RaceGame
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaceGame));
            roadTimer = new System.Windows.Forms.Timer(components);
            gamePanel = new Panel();
            pausePanel = new Panel();
            menuPanel = new Panel();
            userNameLabel = new Label();
            resultButton = new Button();
            helpButton = new Button();
            menuExitButton = new Button();
            startButton = new Button();
            label3 = new Label();
            carMenu1 = new PictureBox();
            carMenu3 = new PictureBox();
            carMenu2 = new PictureBox();
            secondLaneMenu5 = new Label();
            secondLaneMenu4 = new Label();
            secondLaneMenu3 = new Label();
            secondLaneMenu2 = new Label();
            secondLaneMenu1 = new Label();
            firstLaneMenu5 = new Label();
            firstLaneMenu4 = new Label();
            firstLaneMenu3 = new Label();
            firstLaneMenu2 = new Label();
            firstLaneMenu1 = new Label();
            label12 = new Label();
            exitButton = new Button();
            resumeButton = new Button();
            pictureFlag = new PictureBox();
            pauseLabel = new Label();
            scoreLabel = new Label();
            coinsLabel = new Label();
            label = new Label();
            oncomingСar2 = new PictureBox();
            oncomingCar1 = new PictureBox();
            oncomingCar3 = new PictureBox();
            coin3 = new PictureBox();
            coin2 = new PictureBox();
            coin1 = new PictureBox();
            pauseButton = new Button();
            mainCar = new PictureBox();
            secondLane5 = new Label();
            secondLane4 = new Label();
            secondLane3 = new Label();
            secondLane2 = new Label();
            secondLane1 = new Label();
            firstLane5 = new Label();
            firstLane4 = new Label();
            firstLane3 = new Label();
            firstLane2 = new Label();
            firstLane1 = new Label();
            middleLane = new Label();
            oncomingCarsTimer = new System.Windows.Forms.Timer(components);
            menuTimer = new System.Windows.Forms.Timer(components);
            dateTimer = new System.Windows.Forms.Timer(components);
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            gamePanel.SuspendLayout();
            pausePanel.SuspendLayout();
            menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carMenu3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carMenu2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oncomingСar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oncomingCar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oncomingCar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // roadTimer
            // 
            roadTimer.Enabled = true;
            roadTimer.Interval = 1;
            roadTimer.Tick += RoadTimer_Tick;
            // 
            // gamePanel
            // 
            gamePanel.BackColor = SystemColors.ControlDarkDark;
            gamePanel.Controls.Add(pausePanel);
            gamePanel.Controls.Add(scoreLabel);
            gamePanel.Controls.Add(coinsLabel);
            gamePanel.Controls.Add(label);
            gamePanel.Controls.Add(oncomingСar2);
            gamePanel.Controls.Add(oncomingCar1);
            gamePanel.Controls.Add(oncomingCar3);
            gamePanel.Controls.Add(coin3);
            gamePanel.Controls.Add(coin2);
            gamePanel.Controls.Add(coin1);
            gamePanel.Controls.Add(pauseButton);
            gamePanel.Controls.Add(mainCar);
            gamePanel.Controls.Add(secondLane5);
            gamePanel.Controls.Add(secondLane4);
            gamePanel.Controls.Add(secondLane3);
            gamePanel.Controls.Add(secondLane2);
            gamePanel.Controls.Add(secondLane1);
            gamePanel.Controls.Add(firstLane5);
            gamePanel.Controls.Add(firstLane4);
            gamePanel.Controls.Add(firstLane3);
            gamePanel.Controls.Add(firstLane2);
            gamePanel.Controls.Add(firstLane1);
            gamePanel.Controls.Add(middleLane);
            gamePanel.Location = new Point(0, 0);
            gamePanel.Margin = new Padding(4, 5, 4, 5);
            gamePanel.Name = "gamePanel";
            gamePanel.Size = new Size(512, 866);
            gamePanel.TabIndex = 0;
            // 
            // pausePanel
            // 
            pausePanel.BackColor = SystemColors.ControlDarkDark;
            pausePanel.Controls.Add(menuPanel);
            pausePanel.Controls.Add(exitButton);
            pausePanel.Controls.Add(resumeButton);
            pausePanel.Controls.Add(pictureFlag);
            pausePanel.Controls.Add(pauseLabel);
            pausePanel.Location = new Point(0, 0);
            pausePanel.Margin = new Padding(4, 5, 4, 5);
            pausePanel.Name = "pausePanel";
            pausePanel.Size = new Size(515, 872);
            pausePanel.TabIndex = 57;
            // 
            // menuPanel
            // 
            menuPanel.BackColor = SystemColors.ControlDarkDark;
            menuPanel.Controls.Add(statusStrip1);
            menuPanel.Controls.Add(userNameLabel);
            menuPanel.Controls.Add(resultButton);
            menuPanel.Controls.Add(helpButton);
            menuPanel.Controls.Add(menuExitButton);
            menuPanel.Controls.Add(startButton);
            menuPanel.Controls.Add(label3);
            menuPanel.Controls.Add(carMenu1);
            menuPanel.Controls.Add(carMenu3);
            menuPanel.Controls.Add(carMenu2);
            menuPanel.Controls.Add(secondLaneMenu5);
            menuPanel.Controls.Add(secondLaneMenu4);
            menuPanel.Controls.Add(secondLaneMenu3);
            menuPanel.Controls.Add(secondLaneMenu2);
            menuPanel.Controls.Add(secondLaneMenu1);
            menuPanel.Controls.Add(firstLaneMenu5);
            menuPanel.Controls.Add(firstLaneMenu4);
            menuPanel.Controls.Add(firstLaneMenu3);
            menuPanel.Controls.Add(firstLaneMenu2);
            menuPanel.Controls.Add(firstLaneMenu1);
            menuPanel.Controls.Add(label12);
            menuPanel.Location = new Point(0, 0);
            menuPanel.Margin = new Padding(4, 5, 4, 5);
            menuPanel.Name = "menuPanel";
            menuPanel.Size = new Size(515, 867);
            menuPanel.TabIndex = 57;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLabel.Location = new Point(16, 251);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(77, 38);
            userNameLabel.TabIndex = 84;
            userNameLabel.Text = "Имя";
            // 
            // resultButton
            // 
            resultButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            resultButton.Location = new Point(167, 596);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(176, 71);
            resultButton.TabIndex = 83;
            resultButton.Text = "Result";
            resultButton.UseVisualStyleBackColor = true;
            resultButton.Click += resultButton_Click;
            // 
            // helpButton
            // 
            helpButton.Font = new Font("Microsoft YaHei", 10F, FontStyle.Bold, GraphicsUnit.Point);
            helpButton.Location = new Point(413, 812);
            helpButton.Margin = new Padding(4, 5, 4, 5);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(93, 49);
            helpButton.TabIndex = 82;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += buttonHelp_Click;
            // 
            // menuExitButton
            // 
            menuExitButton.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            menuExitButton.Location = new Point(167, 506);
            menuExitButton.Margin = new Padding(4, 5, 4, 5);
            menuExitButton.Name = "menuExitButton";
            menuExitButton.Size = new Size(176, 72);
            menuExitButton.TabIndex = 67;
            menuExitButton.Text = "Exit";
            menuExitButton.UseVisualStyleBackColor = true;
            menuExitButton.Click += buttonMenuExit_Click;
            // 
            // startButton
            // 
            startButton.Font = new Font("Microsoft YaHei", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.Location = new Point(148, 405);
            startButton.Margin = new Padding(4, 5, 4, 5);
            startButton.Name = "startButton";
            startButton.Size = new Size(213, 91);
            startButton.TabIndex = 65;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += buttonStart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(64, 64, 64);
            label3.Font = new Font("Microsoft Tai Le", 105F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(0, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(481, 223);
            label3.TabIndex = 66;
            label3.Text = "Race";
            // 
            // carMenu1
            // 
            carMenu1.BackColor = Color.Transparent;
            carMenu1.Image = (Image)resources.GetObject("carMenu1.Image");
            carMenu1.Location = new Point(16, 20);
            carMenu1.Margin = new Padding(4, 5, 4, 5);
            carMenu1.Name = "carMenu1";
            carMenu1.Size = new Size(67, 169);
            carMenu1.SizeMode = PictureBoxSizeMode.Zoom;
            carMenu1.TabIndex = 80;
            carMenu1.TabStop = false;
            // 
            // carMenu3
            // 
            carMenu3.BackColor = Color.Transparent;
            carMenu3.Image = (Image)resources.GetObject("carMenu3.Image");
            carMenu3.Location = new Point(429, 40);
            carMenu3.Margin = new Padding(4, 5, 4, 5);
            carMenu3.Name = "carMenu3";
            carMenu3.Size = new Size(67, 169);
            carMenu3.SizeMode = PictureBoxSizeMode.Zoom;
            carMenu3.TabIndex = 81;
            carMenu3.TabStop = false;
            // 
            // carMenu2
            // 
            carMenu2.BackColor = Color.Transparent;
            carMenu2.Image = (Image)resources.GetObject("carMenu2.Image");
            carMenu2.Location = new Point(172, 5);
            carMenu2.Margin = new Padding(4, 5, 4, 5);
            carMenu2.Name = "carMenu2";
            carMenu2.Size = new Size(67, 169);
            carMenu2.SizeMode = PictureBoxSizeMode.Zoom;
            carMenu2.TabIndex = 79;
            carMenu2.TabStop = false;
            // 
            // secondLaneMenu5
            // 
            secondLaneMenu5.BackColor = Color.White;
            secondLaneMenu5.ForeColor = SystemColors.Control;
            secondLaneMenu5.Location = new Point(385, 797);
            secondLaneMenu5.Margin = new Padding(4, 0, 4, 0);
            secondLaneMenu5.Name = "secondLaneMenu5";
            secondLaneMenu5.Size = new Size(20, 138);
            secondLaneMenu5.TabIndex = 78;
            secondLaneMenu5.TextAlign = ContentAlignment.TopCenter;
            // 
            // secondLaneMenu4
            // 
            secondLaneMenu4.BackColor = Color.White;
            secondLaneMenu4.ForeColor = SystemColors.Control;
            secondLaneMenu4.Location = new Point(385, 582);
            secondLaneMenu4.Margin = new Padding(4, 0, 4, 0);
            secondLaneMenu4.Name = "secondLaneMenu4";
            secondLaneMenu4.Size = new Size(20, 138);
            secondLaneMenu4.TabIndex = 77;
            secondLaneMenu4.TextAlign = ContentAlignment.TopCenter;
            // 
            // secondLaneMenu3
            // 
            secondLaneMenu3.BackColor = Color.White;
            secondLaneMenu3.ForeColor = SystemColors.Control;
            secondLaneMenu3.Location = new Point(385, 366);
            secondLaneMenu3.Margin = new Padding(4, 0, 4, 0);
            secondLaneMenu3.Name = "secondLaneMenu3";
            secondLaneMenu3.Size = new Size(20, 138);
            secondLaneMenu3.TabIndex = 76;
            secondLaneMenu3.TextAlign = ContentAlignment.TopCenter;
            // 
            // secondLaneMenu2
            // 
            secondLaneMenu2.BackColor = Color.White;
            secondLaneMenu2.ForeColor = SystemColors.Control;
            secondLaneMenu2.Location = new Point(385, 151);
            secondLaneMenu2.Margin = new Padding(4, 0, 4, 0);
            secondLaneMenu2.Name = "secondLaneMenu2";
            secondLaneMenu2.Size = new Size(20, 138);
            secondLaneMenu2.TabIndex = 75;
            secondLaneMenu2.TextAlign = ContentAlignment.TopCenter;
            // 
            // secondLaneMenu1
            // 
            secondLaneMenu1.BackColor = Color.White;
            secondLaneMenu1.ForeColor = SystemColors.Control;
            secondLaneMenu1.Location = new Point(385, -65);
            secondLaneMenu1.Margin = new Padding(4, 0, 4, 0);
            secondLaneMenu1.Name = "secondLaneMenu1";
            secondLaneMenu1.Size = new Size(20, 138);
            secondLaneMenu1.TabIndex = 74;
            secondLaneMenu1.TextAlign = ContentAlignment.TopCenter;
            // 
            // firstLaneMenu5
            // 
            firstLaneMenu5.BackColor = Color.White;
            firstLaneMenu5.ForeColor = SystemColors.Control;
            firstLaneMenu5.Location = new Point(119, 797);
            firstLaneMenu5.Margin = new Padding(4, 0, 4, 0);
            firstLaneMenu5.Name = "firstLaneMenu5";
            firstLaneMenu5.Size = new Size(20, 138);
            firstLaneMenu5.TabIndex = 73;
            firstLaneMenu5.TextAlign = ContentAlignment.TopCenter;
            // 
            // firstLaneMenu4
            // 
            firstLaneMenu4.BackColor = Color.White;
            firstLaneMenu4.ForeColor = SystemColors.Control;
            firstLaneMenu4.Location = new Point(119, 582);
            firstLaneMenu4.Margin = new Padding(4, 0, 4, 0);
            firstLaneMenu4.Name = "firstLaneMenu4";
            firstLaneMenu4.Size = new Size(20, 138);
            firstLaneMenu4.TabIndex = 72;
            firstLaneMenu4.TextAlign = ContentAlignment.TopCenter;
            // 
            // firstLaneMenu3
            // 
            firstLaneMenu3.BackColor = Color.White;
            firstLaneMenu3.ForeColor = SystemColors.Control;
            firstLaneMenu3.Location = new Point(119, 366);
            firstLaneMenu3.Margin = new Padding(4, 0, 4, 0);
            firstLaneMenu3.Name = "firstLaneMenu3";
            firstLaneMenu3.Size = new Size(20, 138);
            firstLaneMenu3.TabIndex = 71;
            firstLaneMenu3.TextAlign = ContentAlignment.TopCenter;
            // 
            // firstLaneMenu2
            // 
            firstLaneMenu2.BackColor = Color.White;
            firstLaneMenu2.ForeColor = SystemColors.Control;
            firstLaneMenu2.Location = new Point(119, 151);
            firstLaneMenu2.Margin = new Padding(4, 0, 4, 0);
            firstLaneMenu2.Name = "firstLaneMenu2";
            firstLaneMenu2.Size = new Size(20, 138);
            firstLaneMenu2.TabIndex = 70;
            firstLaneMenu2.TextAlign = ContentAlignment.TopCenter;
            // 
            // firstLaneMenu1
            // 
            firstLaneMenu1.BackColor = Color.White;
            firstLaneMenu1.ForeColor = SystemColors.Control;
            firstLaneMenu1.Location = new Point(119, -65);
            firstLaneMenu1.Margin = new Padding(4, 0, 4, 0);
            firstLaneMenu1.Name = "firstLaneMenu1";
            firstLaneMenu1.Size = new Size(20, 138);
            firstLaneMenu1.TabIndex = 69;
            firstLaneMenu1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.BackColor = Color.White;
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(245, -6);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(23, 872);
            label12.TabIndex = 68;
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            exitButton.Location = new Point(159, 740);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(203, 62);
            exitButton.TabIndex = 53;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += buttonExit_Click;
            // 
            // resumeButton
            // 
            resumeButton.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            resumeButton.Location = new Point(159, 625);
            resumeButton.Margin = new Padding(4, 5, 4, 5);
            resumeButton.Name = "resumeButton";
            resumeButton.Size = new Size(203, 89);
            resumeButton.TabIndex = 52;
            resumeButton.Text = "Resume";
            resumeButton.UseVisualStyleBackColor = true;
            resumeButton.Click += buttonResume_Click;
            // 
            // pictureFlag
            // 
            pictureFlag.BackColor = SystemColors.ControlDarkDark;
            pictureFlag.Image = (Image)resources.GetObject("pictureFlag.Image");
            pictureFlag.Location = new Point(-3, 166);
            pictureFlag.Margin = new Padding(4, 5, 4, 5);
            pictureFlag.Name = "pictureFlag";
            pictureFlag.Size = new Size(515, 485);
            pictureFlag.SizeMode = PictureBoxSizeMode.Zoom;
            pictureFlag.TabIndex = 55;
            pictureFlag.TabStop = false;
            // 
            // pauseLabel
            // 
            pauseLabel.AutoSize = true;
            pauseLabel.Font = new Font("Microsoft YaHei", 90F, FontStyle.Bold, GraphicsUnit.Point);
            pauseLabel.Location = new Point(0, 0);
            pauseLabel.Margin = new Padding(4, 0, 4, 0);
            pauseLabel.Name = "pauseLabel";
            pauseLabel.Size = new Size(528, 199);
            pauseLabel.TabIndex = 54;
            pauseLabel.Text = "Pause";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = Color.Black;
            scoreLabel.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            scoreLabel.ForeColor = SystemColors.ButtonHighlight;
            scoreLabel.Location = new Point(16, 14);
            scoreLabel.Margin = new Padding(4, 0, 4, 0);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(136, 50);
            scoreLabel.TabIndex = 56;
            scoreLabel.Text = "Score:";
            // 
            // coinsLabel
            // 
            coinsLabel.AutoSize = true;
            coinsLabel.BackColor = Color.Black;
            coinsLabel.Font = new Font("Microsoft YaHei", 22F, FontStyle.Bold, GraphicsUnit.Point);
            coinsLabel.ForeColor = SystemColors.ButtonHighlight;
            coinsLabel.Location = new Point(276, 14);
            coinsLabel.Margin = new Padding(4, 0, 4, 0);
            coinsLabel.Name = "coinsLabel";
            coinsLabel.Size = new Size(135, 50);
            coinsLabel.TabIndex = 57;
            coinsLabel.Text = "Coins:";
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label.BackColor = SystemColors.ActiveCaptionText;
            label.Font = new Font("Microsoft Sans Serif", 100F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ControlText;
            label.Location = new Point(-3, 0);
            label.Margin = new Padding(4, 0, 4, 0);
            label.Name = "label";
            label.Size = new Size(515, 91);
            label.TabIndex = 55;
            // 
            // oncomingСar2
            // 
            oncomingСar2.BackColor = Color.Transparent;
            oncomingСar2.Image = (Image)resources.GetObject("oncomingСar2.Image");
            oncomingСar2.Location = new Point(16, 35);
            oncomingСar2.Margin = new Padding(4, 5, 4, 5);
            oncomingСar2.Name = "oncomingСar2";
            oncomingСar2.Size = new Size(67, 169);
            oncomingСar2.SizeMode = PictureBoxSizeMode.Zoom;
            oncomingСar2.TabIndex = 49;
            oncomingСar2.TabStop = false;
            // 
            // oncomingCar1
            // 
            oncomingCar1.BackColor = Color.Transparent;
            oncomingCar1.Image = (Image)resources.GetObject("oncomingCar1.Image");
            oncomingCar1.Location = new Point(172, 20);
            oncomingCar1.Margin = new Padding(4, 5, 4, 5);
            oncomingCar1.Name = "oncomingCar1";
            oncomingCar1.Size = new Size(67, 169);
            oncomingCar1.SizeMode = PictureBoxSizeMode.Zoom;
            oncomingCar1.TabIndex = 48;
            oncomingCar1.TabStop = false;
            // 
            // oncomingCar3
            // 
            oncomingCar3.BackColor = Color.Transparent;
            oncomingCar3.Image = (Image)resources.GetObject("oncomingCar3.Image");
            oncomingCar3.Location = new Point(429, 55);
            oncomingCar3.Margin = new Padding(4, 5, 4, 5);
            oncomingCar3.Name = "oncomingCar3";
            oncomingCar3.Size = new Size(67, 169);
            oncomingCar3.SizeMode = PictureBoxSizeMode.Zoom;
            oncomingCar3.TabIndex = 50;
            oncomingCar3.TabStop = false;
            // 
            // coin3
            // 
            coin3.BackColor = Color.Transparent;
            coin3.Image = (Image)resources.GetObject("coin3.Image");
            coin3.Location = new Point(429, 343);
            coin3.Margin = new Padding(4, 5, 4, 5);
            coin3.Name = "coin3";
            coin3.Size = new Size(45, 49);
            coin3.SizeMode = PictureBoxSizeMode.Zoom;
            coin3.TabIndex = 54;
            coin3.TabStop = false;
            // 
            // coin2
            // 
            coin2.BackColor = Color.Transparent;
            coin2.Image = (Image)resources.GetObject("coin2.Image");
            coin2.Location = new Point(295, 240);
            coin2.Margin = new Padding(4, 5, 4, 5);
            coin2.Name = "coin2";
            coin2.Size = new Size(45, 49);
            coin2.SizeMode = PictureBoxSizeMode.Zoom;
            coin2.TabIndex = 53;
            coin2.TabStop = false;
            // 
            // coin1
            // 
            coin1.BackColor = Color.Transparent;
            coin1.Image = (Image)resources.GetObject("coin1.Image");
            coin1.Location = new Point(147, 388);
            coin1.Margin = new Padding(4, 5, 4, 5);
            coin1.Name = "coin1";
            coin1.Size = new Size(45, 49);
            coin1.SizeMode = PictureBoxSizeMode.Zoom;
            coin1.TabIndex = 52;
            coin1.TabStop = false;
            // 
            // pauseButton
            // 
            pauseButton.Font = new Font("Microsoft YaHei", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pauseButton.Location = new Point(0, 803);
            pauseButton.Margin = new Padding(4, 5, 4, 5);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(109, 58);
            pauseButton.TabIndex = 1;
            pauseButton.Text = "Pause";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += buttonPause_Click;
            // 
            // mainCar
            // 
            mainCar.BackColor = Color.Transparent;
            mainCar.BackgroundImageLayout = ImageLayout.None;
            mainCar.Image = (Image)resources.GetObject("mainCar.Image");
            mainCar.Location = new Point(295, 677);
            mainCar.Margin = new Padding(4, 5, 4, 5);
            mainCar.Name = "mainCar";
            mainCar.Size = new Size(67, 169);
            mainCar.SizeMode = PictureBoxSizeMode.Zoom;
            mainCar.TabIndex = 47;
            mainCar.TabStop = false;
            // 
            // secondLane5
            // 
            secondLane5.BackColor = Color.White;
            secondLane5.ForeColor = SystemColors.Control;
            secondLane5.Location = new Point(385, 812);
            secondLane5.Margin = new Padding(4, 0, 4, 0);
            secondLane5.Name = "secondLane5";
            secondLane5.Size = new Size(20, 138);
            secondLane5.TabIndex = 43;
            secondLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // secondLane4
            // 
            secondLane4.BackColor = Color.White;
            secondLane4.ForeColor = SystemColors.Control;
            secondLane4.Location = new Point(385, 596);
            secondLane4.Margin = new Padding(4, 0, 4, 0);
            secondLane4.Name = "secondLane4";
            secondLane4.Size = new Size(20, 138);
            secondLane4.TabIndex = 42;
            secondLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // secondLane3
            // 
            secondLane3.BackColor = Color.White;
            secondLane3.ForeColor = SystemColors.Control;
            secondLane3.Location = new Point(385, 382);
            secondLane3.Margin = new Padding(4, 0, 4, 0);
            secondLane3.Name = "secondLane3";
            secondLane3.Size = new Size(20, 138);
            secondLane3.TabIndex = 41;
            secondLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // secondLane2
            // 
            secondLane2.BackColor = Color.White;
            secondLane2.ForeColor = SystemColors.Control;
            secondLane2.Location = new Point(385, 166);
            secondLane2.Margin = new Padding(4, 0, 4, 0);
            secondLane2.Name = "secondLane2";
            secondLane2.Size = new Size(20, 138);
            secondLane2.TabIndex = 40;
            secondLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // secondLane1
            // 
            secondLane1.BackColor = Color.White;
            secondLane1.ForeColor = SystemColors.Control;
            secondLane1.Location = new Point(385, -49);
            secondLane1.Margin = new Padding(4, 0, 4, 0);
            secondLane1.Name = "secondLane1";
            secondLane1.Size = new Size(20, 138);
            secondLane1.TabIndex = 39;
            secondLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // firstLane5
            // 
            firstLane5.BackColor = Color.White;
            firstLane5.ForeColor = SystemColors.Control;
            firstLane5.Location = new Point(119, 812);
            firstLane5.Margin = new Padding(4, 0, 4, 0);
            firstLane5.Name = "firstLane5";
            firstLane5.Size = new Size(20, 138);
            firstLane5.TabIndex = 38;
            firstLane5.TextAlign = ContentAlignment.TopCenter;
            // 
            // firstLane4
            // 
            firstLane4.BackColor = Color.White;
            firstLane4.ForeColor = SystemColors.Control;
            firstLane4.Location = new Point(119, 597);
            firstLane4.Margin = new Padding(4, 0, 4, 0);
            firstLane4.Name = "firstLane4";
            firstLane4.Size = new Size(20, 138);
            firstLane4.TabIndex = 37;
            firstLane4.TextAlign = ContentAlignment.TopCenter;
            // 
            // firstLane3
            // 
            firstLane3.BackColor = Color.White;
            firstLane3.ForeColor = SystemColors.Control;
            firstLane3.Location = new Point(119, 382);
            firstLane3.Margin = new Padding(4, 0, 4, 0);
            firstLane3.Name = "firstLane3";
            firstLane3.Size = new Size(20, 138);
            firstLane3.TabIndex = 36;
            firstLane3.TextAlign = ContentAlignment.TopCenter;
            // 
            // firstLane2
            // 
            firstLane2.BackColor = Color.White;
            firstLane2.ForeColor = SystemColors.Control;
            firstLane2.Location = new Point(119, 166);
            firstLane2.Margin = new Padding(4, 0, 4, 0);
            firstLane2.Name = "firstLane2";
            firstLane2.Size = new Size(20, 138);
            firstLane2.TabIndex = 35;
            firstLane2.TextAlign = ContentAlignment.TopCenter;
            // 
            // firstLane1
            // 
            firstLane1.BackColor = Color.White;
            firstLane1.ForeColor = SystemColors.Control;
            firstLane1.Location = new Point(119, -49);
            firstLane1.Margin = new Padding(4, 0, 4, 0);
            firstLane1.Name = "firstLane1";
            firstLane1.Size = new Size(20, 138);
            firstLane1.TabIndex = 34;
            firstLane1.TextAlign = ContentAlignment.TopCenter;
            // 
            // middleLane
            // 
            middleLane.BackColor = Color.White;
            middleLane.ForeColor = SystemColors.Control;
            middleLane.Location = new Point(245, -6);
            middleLane.Margin = new Padding(4, 0, 4, 0);
            middleLane.Name = "middleLane";
            middleLane.Size = new Size(23, 872);
            middleLane.TabIndex = 33;
            middleLane.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // oncomingCarsTimer
            // 
            oncomingCarsTimer.Enabled = true;
            oncomingCarsTimer.Interval = 1;
            oncomingCarsTimer.Tick += OncomingCarsTimer_Tick;
            // 
            // menuTimer
            // 
            menuTimer.Enabled = true;
            menuTimer.Interval = 1;
            menuTimer.Tick += MenuTimer_Tick;
            // 
            // dateTimer
            // 
            dateTimer.Interval = 1000;
            dateTimer.Tick += dateTimer_Tick;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 841);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(515, 26);
            statusStrip1.TabIndex = 85;
            statusStrip1.Text = "statusStrip1";
            // 
            // RaceGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(512, 865);
            Controls.Add(gamePanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            Margin = new Padding(4, 5, 4, 5);
            Name = "RaceGame";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Race";
            Load += RaceGame_Load;
            KeyDown += RaceGame_KeyDown;
            gamePanel.ResumeLayout(false);
            gamePanel.PerformLayout();
            pausePanel.ResumeLayout(false);
            pausePanel.PerformLayout();
            menuPanel.ResumeLayout(false);
            menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)carMenu3).EndInit();
            ((System.ComponentModel.ISupportInitialize)carMenu2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureFlag).EndInit();
            ((System.ComponentModel.ISupportInitialize)oncomingСar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)oncomingCar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)oncomingCar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin3).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin2).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainCar).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer roadTimer;
		private System.Windows.Forms.Panel gamePanel;
		private System.Windows.Forms.Label secondLane5;
		private System.Windows.Forms.Label secondLane4;
		private System.Windows.Forms.Label secondLane3;
		private System.Windows.Forms.Label secondLane2;
		private System.Windows.Forms.Label secondLane1;
		private System.Windows.Forms.Label firstLane5;
		private System.Windows.Forms.Label firstLane4;
		private System.Windows.Forms.Label firstLane3;
		private System.Windows.Forms.Label firstLane2;
		private System.Windows.Forms.Label firstLane1;
		private System.Windows.Forms.Label middleLane;
		private System.Windows.Forms.PictureBox oncomingСar2;
		private System.Windows.Forms.PictureBox oncomingCar3;
		private System.Windows.Forms.PictureBox oncomingCar1;
		private System.Windows.Forms.PictureBox mainCar;
		private System.Windows.Forms.Timer oncomingCarsTimer;
		private System.Windows.Forms.Timer menuTimer;
		private System.Windows.Forms.Label pauseLabel;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button resumeButton;
		private System.Windows.Forms.Button pauseButton;
		private System.Windows.Forms.PictureBox coin1;
		private System.Windows.Forms.PictureBox coin3;
		private System.Windows.Forms.PictureBox coin2;
		private System.Windows.Forms.Panel pausePanel;
		private System.Windows.Forms.PictureBox pictureFlag;
		private System.Windows.Forms.Label coinsLabel;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Label label;
		private Panel menuPanel;
		private Button helpButton;
		private Button menuExitButton;
		private Button startButton;
		private Label label3;
		private PictureBox carMenu1;
		private PictureBox carMenu3;
		private PictureBox carMenu2;
		private Label secondLaneMenu5;
		private Label secondLaneMenu4;
		private Label secondLaneMenu3;
		private Label secondLaneMenu2;
		private Label secondLaneMenu1;
		private Label firstLaneMenu5;
		private Label firstLaneMenu4;
		private Label firstLaneMenu3;
		private Label firstLaneMenu2;
		private Label firstLaneMenu1;
		private Label label12;
        private Button resultButton;
        private Label userNameLabel;
        private System.Windows.Forms.Timer dateTimer;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
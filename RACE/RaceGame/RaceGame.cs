using RaceCommon;
using WMPLib;
using System.Media;

namespace Race
{
    public partial class RaceGame : Form
    {
        private int score = 0;
        private int coins = 0;
        private int carSpeed = 2;
        const int moveStep = 9;

        private Label[] firstLanes = new Label[5];
        private Label[] secondLanes = new Label[5];
        private Label[] firstLanesMenu = new Label[5];
        private Label[] secondLanesMenu = new Label[5];

        public User user = new User();

        Random random = new Random();

        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();

        public RaceGame()
        {
            InitializeComponent();
        }

        public RaceGame(String userNameTransfer)
        {
            InitializeComponent();
            userNameLabel.Text = userNameTransfer;
        }

        private void RaceGame_Load(object sender, EventArgs e)
        {
            WMP.URL = @"Cradle.wav";
            WMP.settings.volume = 100; // меняя значение можно регулировать громкость

            WMP.controls.play();

            dateTimer.Start();

            firstLanes[0] = firstLane1;
            firstLanes[1] = firstLane2;
            firstLanes[2] = firstLane3;
            firstLanes[3] = firstLane4;
            firstLanes[4] = firstLane5;

            secondLanes[0] = secondLane1;
            secondLanes[1] = secondLane2;
            secondLanes[2] = secondLane3;
            secondLanes[3] = secondLane4;
            secondLanes[4] = secondLane5;

            firstLanesMenu[0] = firstLaneMenu1;
            firstLanesMenu[1] = firstLaneMenu2;
            firstLanesMenu[2] = firstLaneMenu3;
            firstLanesMenu[3] = firstLaneMenu4;
            firstLanesMenu[4] = firstLaneMenu5;

            secondLanesMenu[0] = secondLaneMenu1;
            secondLanesMenu[1] = secondLaneMenu2;
            secondLanesMenu[2] = secondLaneMenu3;
            secondLanesMenu[3] = secondLaneMenu4;
            secondLanesMenu[4] = secondLaneMenu5;

            roadTimer.Stop();
            oncomingCarsTimer.Stop();
        }

        private void StartGame()
        {
            score = 0;
            coins = 0;
            carSpeed = 2;
            roadTimer.Start();
            oncomingCarsTimer.Start();
            oncomingCar1.Top = -oncomingCar1.Height;
            oncomingCar1.Left = random.Next(0, Width - oncomingCar1.Width);
            oncomingСar2.Top = -oncomingСar2.Height;
            oncomingСar2.Left = random.Next(0, Width - oncomingСar2.Width);
            oncomingCar3.Top = -oncomingCar3.Height;
            oncomingCar3.Left = random.Next(0, Width - oncomingCar3.Width);
            pausePanel.Hide();
            gamePanel.Show();
            menuPanel.Hide();
        }

        private void GameOver()
        {
            user.Coin = coins;
            user.Score = score / 10;
            user.SaveTime = toolStripStatusLabel1.Text;
            user.Name = userNameLabel.Text;

            roadTimer.Stop();
            oncomingCarsTimer.Stop();

            if (coins < 3)
            {
                DialogResult gameOver = MessageBox.Show("Game Over!", "Приехали!");
                pausePanel.Show();
                menuPanel.Show();
            }
            else
            {
                DialogResult gameContinue = MessageBox.Show("Продолжить? (-3 coins)", "Приехали!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (gameContinue == DialogResult.Yes)
                {
                    Restart();
                }

                if (gameContinue == DialogResult.No)
                {
                    pausePanel.Show();
                    menuPanel.Show();
                }
            }
            UserManager.Append(user);
        }

        private void Restart()
        {
            coins -= 3;
            coinsLabel.Text = "Coins: " + coins;
            carSpeed = 2;
            roadTimer.Start();
            oncomingCarsTimer.Start();
            oncomingCar1.Top = -oncomingCar1.Height;
            oncomingCar1.Left = random.Next(0, Width - oncomingCar1.Width);
            oncomingСar2.Top = -oncomingСar2.Height;
            oncomingСar2.Left = random.Next(0, Width - oncomingСar2.Width);
            oncomingCar3.Top = -oncomingCar3.Height;
            oncomingCar3.Left = random.Next(0, Width - oncomingCar3.Width);
        }

        private void CollectCoins()
        {
            if (mainCar.Bounds.IntersectsWith(coin1.Bounds))
            {
                coins++;
                coinsLabel.Text = "Coins: " + coins;
                coin1.Top = -coin1.Height;
                coin1.Left = random.Next(0, 120);
            }

            if (mainCar.Bounds.IntersectsWith(coin2.Bounds))
            {
                coins++;
                coinsLabel.Text = "Coins: " + coins;
                coin2.Top = -coin2.Height;
                coin2.Left = random.Next(120, 240);
            }

            if (mainCar.Bounds.IntersectsWith(coin3.Bounds))
            {
                coins++;
                coinsLabel.Text = "Coins: " + coins;
                coin3.Top = -coin3.Height;
                coin3.Left = random.Next(240, 300);
            }

        }

        private void OncomingCarsTimer_Tick(object sender, EventArgs e)
        {
            oncomingCar1.Top += carSpeed + 4;

            if (oncomingCar1.Top > Height)
            {
                oncomingCar1.Top = -oncomingCar1.Height;
                oncomingCar1.Left = random.Next(0, Width - oncomingCar1.Width);
            }

            oncomingСar2.Top += carSpeed + 2;

            if (oncomingСar2.Top > Height)
            {
                oncomingСar2.Top = -oncomingСar2.Height;
                oncomingСar2.Left = random.Next(0, Width - oncomingСar2.Width);
            }

            oncomingCar3.Top += carSpeed + 3;

            if (oncomingCar3.Top > Height)
            {
                oncomingCar3.Top = -oncomingCar3.Height;
                oncomingCar3.Left = random.Next(0, Width - oncomingCar3.Width);
            }

            if (mainCar.Bounds.IntersectsWith(oncomingCar1.Bounds))
                GameOver();

            if (mainCar.Bounds.IntersectsWith(oncomingСar2.Bounds))
                GameOver();

            if (mainCar.Bounds.IntersectsWith(oncomingCar3.Bounds))
                GameOver();
        }

        private void RoadTimer_Tick(object sender, EventArgs e)
        {
            scoreLabel.Text = "Score: " + score / 10;

            for (int i = 0; i < firstLanes.Length; ++i)
            {
                firstLanes[i].Top += carSpeed;

                if (firstLanes[i].Top >= Height)
                    firstLanes[i].Top = -firstLanes[i].Height;

                if (carSpeed != 0)
                    score++;
            }

            for (int i = 0; i < secondLanes.Length; ++i)
            {
                secondLanes[i].Top += carSpeed;

                if (secondLanes[i].Top >= Height)
                    secondLanes[i].Top = -secondLanes[i].Height;
            }

            coin1.Top += carSpeed;

            if (coin1.Top > Height)
            {
                coin1.Top = -coin1.Height;
                coin1.Left = random.Next(0, Width - coin1.Width);
            }

            coin2.Top += carSpeed;

            if (coin2.Top > Height)
            {
                coin2.Top = -coin2.Height;
                coin2.Left = random.Next(0, Width - coin2.Width);
            }

            coin3.Top += carSpeed;

            if (coin3.Top > Height)
            {
                coin3.Top = -coin3.Height;
                coin3.Left = random.Next(0, Width - coin3.Width);
            }

            CollectCoins();
        }

        private void MenuTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < firstLanesMenu.Length; ++i)
            {
                firstLanesMenu[i].Top += carSpeed;

                if (firstLanesMenu[i].Top >= Height)
                {
                    firstLanesMenu[i].Top = -firstLanesMenu[i].Height;
                }
            }
            for (int i = 0; i < secondLanesMenu.Length; ++i)
            {
                secondLanesMenu[i].Top += carSpeed;

                if (secondLanesMenu[i].Top >= Height)
                    secondLanesMenu[i].Top = -secondLanesMenu[i].Height;
            }

            carMenu1.Top += 5;

            if (carMenu1.Top > Height)
            {
                carMenu1.Top = -carMenu1.Height;
                carMenu1.Left = random.Next(0, Width - carMenu1.Width);
            }

            carMenu2.Top += 3;

            if (carMenu2.Top > Height)
            {
                carMenu2.Top = -carMenu2.Height;
                carMenu2.Left = random.Next(0, Width - carMenu2.Width);
            }

            carMenu3.Top += 4;

            if (carMenu3.Top > Height)
            {
                carMenu3.Top = -carMenu3.Height;
                carMenu3.Left = random.Next(0, Width - carMenu3.Width);
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {

            roadTimer.Enabled = false;
            oncomingCarsTimer.Enabled = false;
            pausePanel.Show();
        }

        private void buttonResume_Click(object sender, EventArgs e)
        {
            roadTimer.Enabled = true;
            oncomingCarsTimer.Enabled = true;
            pausePanel.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            menuPanel.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, @"C:\Users\khha4\Race\help.chm", HelpNavigator.TableOfContents);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartGame();
            gamePanel.Show();
            menuPanel.Hide();
        }

        private void buttonMenuExit_Click(object sender, EventArgs e)
        {
            WMP.controls.stop(); // Стоп
            WMP.close();
            this.Close();
        }

        private void RaceGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (carSpeed != 0)
            {
                if (e.KeyCode == Keys.Right)
                {
                    if (mainCar.Left <= ClientSize.Width)
                        mainCar.Left += moveStep;

                    if (ClientSize.Width - mainCar.Left < mainCar.Width / 2)
                        mainCar.Left = mainCar.Left - ClientSize.Width;
                }

                if (e.KeyCode == Keys.Left)
                {
                    if (mainCar.Left >= -mainCar.Width / 2)
                        mainCar.Left -= moveStep;

                    if (mainCar.Left < -mainCar.Width / 2)
                        mainCar.Left = ClientSize.Width - mainCar.Width / 2;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (carSpeed < 21)
                    carSpeed++;
            }

            if (e.KeyCode == Keys.Down)
            {
                if (carSpeed > 0)
                    carSpeed--;
            }

            if (e.KeyCode == Keys.Escape)
            {
                roadTimer.Enabled = false;
                oncomingCarsTimer.Enabled = false;
                pausePanel.Show();
            }
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            WMP.controls.stop(); // Стоп
            WMP.close();

            resultForm f = new resultForm(userNameLabel.Text);
            f.Show();
            this.Hide();
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}


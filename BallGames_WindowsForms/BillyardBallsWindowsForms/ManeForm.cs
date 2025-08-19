using BallCommon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static BillyardBallsWindowsForms.BillyardBall;

namespace BillyardBallsWindowsForms
{
    public partial class ManeForm : Form
    {
        private Timer timer = new Timer();
        private List<BillyardBall> balls = new List<BillyardBall>();
        int ballCount = 20;

        public ManeForm()
        {
            InitializeComponent();
            timer.Interval = 15;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ShowVerticalCenterLine();

            int leftCenterBlueCount = 0;
            int rightCenterBlueCount = 0;

            int leftCenterRedCount = 0;
            int rightCenterRedCount = 0;

            foreach (var ball in balls)
            {
                if (ball.LeftOfCenter())
                {
                    if (ball.GetBrush() == Brushes.Red)
                    {
                        leftCenterRedCount++;
                    }
                    else
                    {
                        leftCenterBlueCount++;
                    }

                }
                if (ball.RightOfCenter())
                {
                    if (ball.GetBrush() == Brushes.Red)
                    {
                        rightCenterRedCount++;
                    }
                    else
                    {
                        rightCenterBlueCount++;
                    }
                }
            }
            if (rightCenterRedCount == leftCenterRedCount && rightCenterBlueCount == leftCenterBlueCount &&
                rightCenterRedCount + rightCenterBlueCount + leftCenterRedCount + leftCenterBlueCount == ballCount)
            {
                foreach (var ball in balls)
                {
                    ball.Stop();
                }
            }
        }
        private void ManeForm_Load(object sender, EventArgs e)
        {
            LoadMenuSettings();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void StartGame()
        {
            timer.Start();

            balls = new List<BillyardBall>();

            for (int i = 0; i < ballCount / 2; i++)
            {
                var ball = new BillyardBall(this, Brushes.Red);
                ball.OnHited += Ball_OnHited;
                balls.Add(ball);
                ball.Start();

                ball = new BillyardBall(this, Brushes.Blue);
                ball.OnHited += Ball_OnHited_2;
                balls.Add(ball);
                ball.Start();
            }
            LoadGameOnSettings();
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in balls)
            {
                ball.Stop();
            }

            LoadGameOnSettings();
            StartGame();
        }
        private void startMenuButton_Click(object sender, EventArgs e)
        {
            timer.Stop();

            HideVerticalCenterLine();

            foreach (var ball in balls)
            {
                ball.Stop();
            }
            ClearPlayingField();
            LoadMenuSettings();
        }
        private void LoadGameOnSettings()
        {
            redLeftLabel.Text = "0";
            redRightLabel.Text = "0";
            redTopLabel.Text = "0";
            redDownLabel.Text = "0";

            blueLabelLeft.Text = "0";
            blueLabelRight.Text = "0";
            blueLabelTop.Text = "0";
            blueLabelDown.Text = "0";

            gameNameLabel.Visible = false;

            blueLabelLeft.Visible = true;
            blueLabelRight.Visible = true;
            blueLabelTop.Visible = true;
            blueLabelDown.Visible = true;

            redLeftLabel.Visible = true;
            redRightLabel.Visible = true;
            redTopLabel.Visible = true;
            redDownLabel.Visible = true;

            startButton.Enabled = false;
            startButton.Visible = false;
            startLabel.Visible = false;

            exitButton.Enabled = false;
            exitpLabel.Visible = false;
            exitButton.Visible = false;

            restartButton.Visible = true;
            restartButton.Enabled = true;

            startMenuButton.Visible = true;
            startMenuButton.Enabled = true;

            ClearPlayingField();
        }
        private void LoadMenuSettings()
        {
            redLeftLabel.Visible = false;
            redRightLabel.Visible = false;
            redTopLabel.Visible = false;
            redDownLabel.Visible = false;

            blueLabelLeft.Visible = false;
            blueLabelRight.Visible = false;
            blueLabelTop.Visible = false;
            blueLabelDown.Visible = false;

            gameNameLabel.Visible = true;

            restartButton.Visible = false;
            restartButton.Enabled = false;

            startMenuButton.Visible = false;
            startMenuButton.Enabled = false;

            startButton.Enabled = true;
            startButton.Visible = true;
            startLabel.Visible = true;

            exitButton.Enabled = true;
            exitpLabel.Visible = true;
            exitButton.Visible = true;
        }
        private void HideVerticalCenterLine()
        {
            var graphics = CreateGraphics();
            graphics.DrawLine(Pens.White, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
        }
        private void ShowVerticalCenterLine()
        {
            var graphics = CreateGraphics();
            graphics.DrawLine(Pens.Black, ClientSize.Width / 2, 0, ClientSize.Width / 2, ClientSize.Height);
        }

        private void Ball_OnHited(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    redLeftLabel.Text = (Convert.ToInt32(redLeftLabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    redRightLabel.Text = (Convert.ToInt32(redRightLabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    redTopLabel.Text = (Convert.ToInt32(redTopLabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    redDownLabel.Text = (Convert.ToInt32(redDownLabel.Text) + 1).ToString();
                    break;
            }
        }

        private void Ball_OnHited_2(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    blueLabelLeft.Text = (Convert.ToInt32(blueLabelLeft.Text) + 1).ToString();
                    break;
                case Side.Right:
                    blueLabelRight.Text = (Convert.ToInt32(blueLabelRight.Text) + 1).ToString();
                    break;
                case Side.Top:
                    blueLabelTop.Text = (Convert.ToInt32(blueLabelTop.Text) + 1).ToString();
                    break;
                case Side.Down:
                    blueLabelDown.Text = (Convert.ToInt32(blueLabelDown.Text) + 1).ToString();
                    break;
            }
        }
        public void ClearPlayingField()
        {
            foreach (var ball in balls)
            {
                ball.Clear();
            }
        }
    }
}
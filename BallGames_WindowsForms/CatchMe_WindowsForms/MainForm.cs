using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BallCommon;
using static BillyardBallsWindowsForms.CatchBall;

namespace CatchMe_WindowsForms
{
    public partial class mainForm : Form
    {
        private List<CatchBall> moveBalls;
        private int countBalls = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            LoadMenuSettings();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restartGameButton(object sender, EventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                ball.Stop();
            }

            MessageBox.Show("Пойманых шариков : " + countBallsLabel.Text + " Шариков Отскочило : " + hitCountScore.Text);

            ClearPlayingField();
            LoadMenuSettings();
            countBallsLabel.Text = "0";
            hitCountScore.Text = "0";
            StartGame();
        }

        private void startMebuButton_Click(object sender, EventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                ball.Stop();
            }
            MessageBox.Show("Пойманых шариков : " + countBallsLabel.Text + " Шариков Отскочило : " + hitCountScore.Text);
           
            ClearPlayingField();
            LoadMenuSettings();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        public void StartGame()
        {
            countBalls = 0;
            hitCountScore.Text = "0";
            countBallsLabel.Text = countBalls.ToString();

            moveBalls = new List<CatchBall>();

            for (int i = 0; i < 10; i++)
            {
                var ball = new CatchBall(this, Brushes.DarkGray);
                moveBalls.Add(ball);
                ball.OnHited += Ball_OnHited;
                ball.Start();
            }

            LoadGameOnSettings();
        }

        private void LoadGameOnSettings()
        {
            startButton.Enabled = false;
            startButton.Visible = false;
            startLabel.Visible = false;

            exitButton.Enabled = false;
            exitButton.Visible = false;
            exitpLabel.Visible = false;

            restartButton.Visible = true;
            restartButton.Enabled = true;

            mainLabel.Visible = false;

            cathTextLabel.Visible = true;
            countBallsLabel.Visible = true;

            hitCountScore.Visible = true;
            hitCountText.Visible = true;

            startMenuButton.Visible = true;
            startMenuButton.Enabled = true;
        }

        private void Ball_OnHited(object sender, BillyardBallsWindowsForms.CatchBall.HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    hitCountScore.Text = (Convert.ToInt32(hitCountScore.Text) + 1).ToString();
                    break;
                case Side.Right:
                    hitCountScore.Text = (Convert.ToInt32(hitCountScore.Text) + 1).ToString();
                    break;
                case Side.Top:
                    hitCountScore.Text = (Convert.ToInt32(hitCountScore.Text) + 1).ToString();
                    break;
                case Side.Down:
                    hitCountScore.Text = (Convert.ToInt32(hitCountScore.Text) + 1).ToString();
                    break;
            }
        }

        private void LoadMenuSettings()
        {
            startButton.Enabled = true;
            startButton.Visible = true;
            startLabel.Visible = true;

            exitButton.Enabled = true;
            exitpLabel.Visible = true;
            exitButton.Visible = true;

            restartButton.Visible = false;
            restartButton.Enabled = false;

            mainLabel.Visible = true;
            
            countBallsLabel.Visible = false;

            cathTextLabel.Visible = false;
            countBallsLabel.Visible = false;

            startMenuButton.Visible = false;
            startMenuButton.Enabled = false;

            hitCountScore.Visible = false;
            hitCountText.Visible = false;
        }
        public void ClearPlayingField()
        {
            foreach (var ball in moveBalls)
            {
                ball.Clear();
            }
        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (moveBalls != null)
            {
                foreach (var ball in moveBalls)
                {
                    if (ball.IsMovuble() && ball.IsCollides(e.X, e.Y))
                    {
                        ball.Stop();
                        ball.Clear();
                        countBalls++;
                    }
                }
                countBallsLabel.Text = countBalls.ToString();
            }
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BallCommon;

namespace BallGames_WindowsForms
{
    public partial class MainForm : Form
    {
        List<Ball> balls = new List<Ball>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDefaultSettings();
        }

        private void randomBallButton_Click(object sender, EventArgs e)
        {
            balls = new List<Ball>();

            for (int i = 0; i < 10; i++)
            {
                var ball = new MoveBall(this, Brushes.DarkOrchid);
                balls.Add(ball);
                ball.Start();
            }

            startButton.Enabled = false;
            startButton.Visible = false;
            catchLabel.Visible = true;
            startLabel.Visible = false;

            stopButton.Enabled = true;
            stopButton.Visible = true;

            exitButton.Enabled = false;
            exitButton.Visible = false;
            exitpLabel.Visible = false;

            mainLabel.Visible = false;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            var countBalls = 0;

            foreach (var ball in balls)
            {
                ball.Stop();

                if (ball.PostedOnForm())
                {
                    countBalls++;
                }
            }
            MessageBox.Show("Вы поймали : " + countBalls + " шариков.");
            LoadDefaultSettings();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void LoadDefaultSettings()
        {
            startButton.Enabled = true;
            startButton.Visible = true;
            startLabel.Visible = true;

            catchLabel.Visible = false;
            stopButton.Enabled = false;
            stopButton.Visible = false;

            exitButton.Enabled = true;
            exitpLabel.Visible = true;
            exitButton.Visible = true;

            mainLabel.Visible = true;

            ClearPlayingField();
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

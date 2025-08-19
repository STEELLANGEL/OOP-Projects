using BallCommon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FruitNinja_WinForms
{
    public partial class MainForm : Form
    {
        private static Random random = new Random();
        private Timer timer = new Timer();
        private Timer slowTimer = new Timer();
        private List<FruitBall> fruits = new List<FruitBall>();
        private List<FruitBall> fruitsToRemoved = new List<FruitBall>();
        private int score = 0;

        public MainForm()
        {
            InitializeComponent();
            slowTimer.Interval = 5000;
            slowTimer.Tick += SlowTimer_Tick;
        }

        private void SlowTimer_Tick(object sender, EventArgs e)
        {
            foreach (var ball in fruits)
            {
                ball.ResetSpeed();
            }
            slowTimer.Stop();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            StartGame();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var fruit in fruits)
            {
                if (fruit.IsMovuble() && fruit.IsCollides(e.X, e.Y))
                {
                    fruit.Stop();

                    if (fruit is BombBall)
                    {
                        EndGame();
                        return;
                    }

                    if (fruit is BananaBall)
                    {
                        SlowedFruits(); 
                    }
                    fruit.Clear();
                    fruitsToRemoved.Add(fruit);  
                    score++;
                }
  
            }
            foreach (var fruit in fruitsToRemoved)
            {
                if (fruit.IsMovuble() && fruit.IsCollides(e.X, e.Y))
                {
                    fruits.Remove(fruit);
                }

            }
            count.Text = score.ToString();
            count.Text = score.ToString();
        }

        private void SlowedFruits()
        {
            foreach (var ball in fruits)
            {
                if (ball.IsMovuble())
                {
                    ball.SlowedSpeed();
                }
                slowTimer.Stop();
                slowTimer.Start();
            }
        }

        private void EndGame()
        {
            timer.Stop();
            foreach (var fruit in fruits)
            {
                fruit.Stop();
            }
            MessageBox.Show("Конец игры. Ваш результат : " + count.Text);
            
            Application.Restart();    
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                EndGame() ;
                LoadMenuSettings();
            }
        }

        private void LoadMenuSettings()
        {
            score = 0;

            pictureBox1.Visible = true;

            startButton.Enabled = true;
            startButton.Visible = true;

            count.Visible = false;
            countSliceText.Visible = false;
            escTextLabel.Visible = false;

            exitButton.Enabled = true;
            exitButton.Visible = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            for (int i = 0; i < random.Next(5,10); i++)
            {
                Brush brush = new SolidBrush(Color.FromArgb((byte)random.Next(1, 255),
                   (byte)random.Next(1, 255), (byte)random.Next(1, 233)));

                FruitBall ball;

                var bombNamber = random.Next(11);

                if (bombNamber == 1)
                {
                    ball = new BombBall(this);
                }
                else
                {
                    if (bombNamber == 2)
                    {
                        ball = new BananaBall(this);
                    }
                    else
                    {
                        ball = new FruitBall(this, brush);
                    } 
                }
                if (slowTimer.Enabled == true)
                {
                    ball.SlowedSpeed(); 
                    slowTimer.Start();
                }
                fruits.Add(ball);
                ball.Start();
            }
            timer.Interval = random.Next(4000, 6000);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            LoadGameSettings();

            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void LoadGameSettings()
        {
            pictureBox1.Visible = false;

            startButton.Enabled = false;
            startButton.Visible = false;

            escTextLabel.Visible = true;
            countSliceText.Visible = true;
            count.Visible = true;

            exitButton.Enabled = false;
            exitButton.Visible = false;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadMenuSettings();
        }
    }
}

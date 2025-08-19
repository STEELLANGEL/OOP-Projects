using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http.Headers;
using System.Windows.Forms;

namespace AngryBirds_WindowsForms
{
    public partial class Main : Form
    {
        Timer timer = new Timer();
        Pig pig;
        Bird bird;
        private int score = 0;

        List<Pig> pigs = new List<Pig>(); 

        public Main()
        {
            InitializeComponent();

            timer.Interval = 1;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Start();
            if (bird.Intersect(pig))
            {
                timer.Stop();

                bird.CollidesPig();

                pig.CollidesBird();

                score += 1;
            }
            //foreach (Pig pig in pigs)
            //{
            //    if (bird.Intersect(pig))
            //    {
            //        timer.Stop();

            //        bird.CollidesPig();

            //        pig.CollidesBird();

            //        score += 1;
            //    }
            //    //timer.Start();

            //}
            if (bird.IsDownSide() && pig.IsDownSide())
            {
                CreatePig();
                CreateBird();
            }
            scoreLabel.Text = score.ToString();
        }

        public void CreateBird()
        {
            if (bird != null)
            {
                bird.Stop();
                bird.Clear();
            }
            bird = new Bird(this);
            bird.Show();
            timer.Stop();
        }

        public void CreatePig()
        {
            if (pig != null)
            {
                pig.Stop();
                pig.Clear();
            }

            pig = new Pig(this);

            pigs.Add(pig);

            pig.Show();

            //for (int i = 0; i < 3; i++)
            //{
            //    pig = new Pig(this);

            //    pigs.Add(pig);

            //    pig.Show();
            //}
            //if (pig != null)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        pig.Stop();
            //        pig.Clear();
            //    }

            //    pig = new Pig(this);
            //    pig.Show();
            //}
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            timer.Start();
            bird.SetVelocity(e.X, e.Y);
            bird.Start();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;

            startButton.Visible = false;
            startButton.Enabled = false;

            exitButton.Visible = false;
            exitButton.Enabled = false;

            scoreLabel.Visible = true;
            killLabel.Visible = true;
            
            timer.Start();
            CreateBird();
            CreatePig();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            scoreLabel.Visible = true;
            killLabel.Visible = true;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Restart();
            }
        }
    } 
}

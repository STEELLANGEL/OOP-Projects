using BallCommon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SalutWindowsForms
{
    public partial class MainForm : Form
    {
        private List<SalutBall> balls;
        Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            balls = new List<SalutBall>();

            var randomQuantity = random.Next(5,15);

            for (int i = 0; i < randomQuantity; i++)
            {
                Brush brush = new SolidBrush(Color.FromArgb((byte)random.Next(1, 255), 
                    (byte)random.Next(1, 255), (byte)random.Next(1, 233)));

                var salutBall = new SalutBall(this,brush, e.X, e.Y);
                balls.Add(salutBall);
                salutBall.Start();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < random.Next(7, 15); i++)
            {
                var ball = new StartSalutBall(this);
                ball.TopReached += Ball_TopReached;
                ball.Start();
            }
            
        }

        private void Ball_TopReached(object sender, BallCommon.TopEventArgs e)
        {
            balls = new List<SalutBall>();

            var randomQuantity = random.Next(10, 21);

            for (int i = 0; i < randomQuantity; i++)
            {
                Brush brush = new SolidBrush(Color.FromArgb((byte)random.Next(1, 255),
                    (byte)random.Next(1, 255), (byte)random.Next(1, 233)));

                var salutBall = new SalutBall(this, brush, e.X, e.Y);
                balls.Add(salutBall);
                salutBall.Start();
            }
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
using BallCommon;

namespace AngryBirds_WindowsForms
{
    public class Bird : RandomMoveBall
    {
        private float g = 0.8f;

        public Bird(Form form) : base(form)
        {
            radius = 25;
            timer.Interval = 30;

            centerX = LeftSide();
            centerY = DownSide();

            this.brush = Brushes.Black;
        }
        protected override void Go()
        {
            base.Go();

            if (centerY >= DownSide())
            {
                centerY = DownSide();
                vy = -vy;
                vy = vy / frictionForce;
                vx = vx / frictionForce;
            }
            vy += g;

            if (centerY <= TopSide())
            {
                centerY = TopSide();
                vy = -vy;
                vy = vy / (frictionForce + wheightBoost);
                vx = vx / (frictionForce + wheightBoost);
            }

            if (centerX >= RightSide())
            {
                centerX = RightSide();
                vx = -vx;
                vy = vy / (frictionForce + wheightBoost);
                vx = vx / (frictionForce + wheightBoost);
            }
            if (centerX <= LeftSide())
            {
                centerX = LeftSide();
                vx = -vx;
                vy = vy / (frictionForce + wheightBoost);
                vx = vx / (frictionForce + wheightBoost);
            }
            vy += g;

        }
        public void CollidesPig()
        {
            vy = vy / (frictionForce + wheightBoost);
            vx = vx / (frictionForce + wheightBoost);

            vx = -vx;
            vy = -vy;

            timer.Start();
        }
    }
}


using System;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using BallCommon;

namespace FruitNinja_WinForms
{
    public class FruitBall : RandomMoveBall
    {
        private float g = 0.2f;

        public FruitBall(Form form) : base(form)
        {
            radius = 30;
            centerY = form.ClientSize.Height + radius;
            timer.Interval = 25;

            vy = (float)random.NextDouble() * -8 - 9;
        }

        public FruitBall(Form form, Brush brush) : base(form)
        {
            radius = 25;
            centerY = form.ClientSize.Height + radius;
            this.brush = brush;
            timer.Interval = 25;

            vy = (float)random.NextDouble() * -8 -9;

        }

        protected override void Go()
        {

            base.Go();

            if (centerX >= RightSide())
            {
                vx = -vx;
            }

            if (centerX <= LeftSide())
            {
                vx = -vx;
            }

            if (centerY <= TopSide())
            {
                vy = -vy;
            }

            vy += g;

            if (centerY > DownSide() + 2 *radius)
            {
                Stop();
            }
        }
    }
}

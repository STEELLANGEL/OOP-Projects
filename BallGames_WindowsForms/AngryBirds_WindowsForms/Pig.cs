using BallCommon;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirds_WindowsForms
{
    public class Pig : MoveBalls
    {
        private float g = 1.1f;

        public Pig(Form form) : base (form)
        {
            radius = 33;

            timer.Interval = 23;

            frictionForce = 1.8f;

            centerX = random.Next(form.Width/2,RightSide());
            centerY = random.Next(TopSide(),DownSide());

            this.brush = Brushes.Pink;
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

            if (centerX >= RightSide())
            {
                centerX = RightSide();
                vx = -vx;
                vy = vy / frictionForce;
                vx = vx / frictionForce;
            }

            if (centerY <= TopSide())
            {
                centerY = TopSide();
                vy = -vy;
                vy = vy / (frictionForce);
                vx = vx / (frictionForce);
            }
            vy += g;
        }
        public void CollidesBird()
        {
            vx = -vx;
            vy = -vy;

            isCollides = true;

            timer.Start();

        }
    }
}

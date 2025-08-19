using BallCommon;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BillyardBallsWindowsForms
{
    internal partial class BillyardBall : RandomMoveBall
    {

        public event EventHandler<HitEventArgs> OnHited;
        //public BillyardBall(Form form) : base(form)
        //{
        //    radius = 10;
        //}

        public BillyardBall(Form form, Brush brush) : base(form)
        {
            radius = 10;
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
            this.brush = brush;
        }

        protected override void Go()
        {
            base.Go();

            if (centerX >= RightSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
            }

            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
            }

            if (centerY >= DownSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
            }

            if (centerY <= TopSide())
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
            }
        }
        
    }
}

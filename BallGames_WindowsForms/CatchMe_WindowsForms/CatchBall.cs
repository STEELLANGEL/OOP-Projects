using BallCommon;
using System;
using System.Drawing;
using System.Windows.Forms;
using static BillyardBallsWindowsForms.CatchBall;

namespace CatchMe_WindowsForms
{
    internal partial class CatchBall : RandomMoveBall
    {
        public event EventHandler<HitEventArgs> OnHited;

        private int limitBallHit = 0;

        public CatchBall(Form form, Brush brush) : base(form)
        {
            this.brush = brush;
        }
        protected override void Go()
        {
            base.Go();

            if (centerX >= RightSide() && limitBallHit != 3)
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Right));
                limitBallHit += 1;
            }

            if (centerX <= LeftSide() && limitBallHit != 3)
            {
                vx = -vx;
                OnHited.Invoke(this, new HitEventArgs(Side.Left));
                limitBallHit += 1;
            }

            if (centerY >= DownSide() && limitBallHit != 3)
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Down));
                limitBallHit += 1;
            }

            if (centerY <= TopSide() && limitBallHit != 3)
            {
                vy = -vy;
                OnHited.Invoke(this, new HitEventArgs(Side.Top));
                limitBallHit += 1;
            }
        }
    }
}

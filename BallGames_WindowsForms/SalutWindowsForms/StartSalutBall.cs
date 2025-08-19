using BallCommon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalutWindowsForms
{
    public class StartSalutBall : SalutBall
    {
        public event EventHandler<TopEventArgs> TopReached;
        public StartSalutBall(Form form) : base(form)
        {
            radius = 8;

            centerX = form.ClientSize.Width / 2;
            centerY = form.ClientSize.Height;

            vy = (float)random.Next(-12, -10);
            vx = (float)random.Next(-4, 4);
            this.brush = Brushes.Black;
        }
        protected override void Go()
        {
            base.Go();

            if (vy > 0)
            {
                Stop();
                TopReached?.Invoke(this, new TopEventArgs(centerX,centerY));
            }
        }
    }
}

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
    public class SalutBall : RandomMoveBall
    {
        private float g = 0.2f;

        public SalutBall(Form form) : base(form)
        {

        }

        public SalutBall(Form form, Brush brush, float centerX, float centerY) : base(form)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.brush = brush;

            radius = random.Next(7, 10);

            vy = - Math.Abs(vy);
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;
namespace BallCommon
{
    public class MoveBalls : RandomPointBall
    {
        public MoveBalls(Form form) : base(form)
        {
            vx = GenerateRandomProjection();
            vy = GenerateRandomProjection();
        }

        private int GenerateRandomProjection()
        {
            var randomDouble = random.NextDouble();
            var sign = -1;

            if (randomDouble < 0.5)
                sign = -1;
            
            return random.Next(2, 5) * sign;
        }
    }
}

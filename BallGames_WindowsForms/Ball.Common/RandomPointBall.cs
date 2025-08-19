using System;
using System.Windows.Forms;

namespace BallCommon
{
    public class RandomPointBall : RandomBallSize
    {
        public RandomPointBall(Form form) : base(form)
        {
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
        }
    }
}

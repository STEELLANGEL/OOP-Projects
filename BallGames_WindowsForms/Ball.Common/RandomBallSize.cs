using System.Windows.Forms;

namespace BallCommon
{
    public class RandomBallSize: Ball
    {
        public RandomBallSize(Form form) : base(form)
        {
            radius = random.Next(20, 40);
        }
    }
}

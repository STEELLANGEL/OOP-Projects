using static BillyardBallsWindowsForms.BillyardBall;

namespace BillyardBallsWindowsForms
{
    class HitEventArgs
    {
        public Side Side;

        public HitEventArgs(Side side)
        {
            Side = side;
        }
    }
}

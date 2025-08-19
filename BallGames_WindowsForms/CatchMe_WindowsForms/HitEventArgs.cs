namespace BillyardBallsWindowsForms
{
    internal partial class CatchBall
    {
        public class HitEventArgs
        {
            public Side Side;

            public HitEventArgs(Side side)
            {
                Side = side;
            }
        }
    }
}

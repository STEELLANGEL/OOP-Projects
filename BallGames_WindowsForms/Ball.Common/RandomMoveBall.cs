using System.Net.Mail;
using System.Net;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace BallCommon
{
    public class RandomMoveBall : MoveBalls
    {
        public RandomMoveBall(Form form) : base(form)
        {
            var vectorX = random.Next(-5, 5);
            var vectorY = random.Next(-5, 5);

            if (GetMoveBallVector(vectorX, vectorY) == false)
            {
                return;
            }
            vx = vectorX;
            vy = vectorY;
        }
        private bool GetMoveBallVector(int vectorX, int vectorY)
        {
            if (vectorX != 0 && vectorY != 0)
                return true;

            return false;
        }
    }
}

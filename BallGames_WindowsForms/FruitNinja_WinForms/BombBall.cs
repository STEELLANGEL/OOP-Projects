using BallCommon;
using System.Drawing;
using System.Windows.Forms;

namespace FruitNinja_WinForms
{
    public class BombBall : FruitBall
    {
        public BombBall(Form form) : base(form)
        {
            this.brush = Brushes.Black;
        }
    }
}

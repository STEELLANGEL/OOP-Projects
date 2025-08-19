using System.Drawing;
using System.Windows.Forms;

namespace FruitNinja_WinForms
{
    public class BananaBall : FruitBall
    {
        public BananaBall(Form form) : base(form)
        {
            this.brush = Brushes.Yellow;
        }
    }
}

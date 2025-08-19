using BallCommon;
using System.Drawing;
using System.Windows.Forms;

namespace BallGames_WindowsForms
{
    internal class MoveBall : RandomMoveBall
    {
        public MoveBall(Form form, Brush brush) : base(form)
        {
            this.brush = brush;
        }
    }
}

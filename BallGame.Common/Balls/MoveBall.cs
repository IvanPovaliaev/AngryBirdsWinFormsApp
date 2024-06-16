using System.Windows.Forms;

namespace BallGame.Common
{    public class MoveBall : RandomSizePointBall
    {
        public MoveBall(Form form) : base(form)
        {
            vx = random.Next(-20, 20);
            vy = random.Next(-20, 20);
        }
    }
}

using System.Windows.Forms;

namespace BallGame.Common
{
    public class RandomMoveBall : RandomSizePointBall
    {
        public RandomMoveBall(Form form) : base(form)
        {
        }
        protected override void Go()
        {
            vx = random.Next(-20, 20);
            vy = random.Next(-20, 20);
            centerX += vx;
            centerY += vy;
        }
    }
}

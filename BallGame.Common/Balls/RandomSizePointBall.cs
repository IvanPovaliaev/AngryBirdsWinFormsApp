using System.Windows.Forms;

namespace BallGame.Common
{
    public class RandomSizePointBall : RandomPointBall
    {
        public RandomSizePointBall(Form form) : base(form)
        {
            radius = random.Next(7, 40);
            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(), DownSide());
        }
    }
}

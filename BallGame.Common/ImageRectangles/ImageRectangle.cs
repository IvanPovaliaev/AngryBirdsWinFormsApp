using System.Drawing;
using System.Windows.Forms;

namespace BallGame.Common
{
    public abstract class ImageRectangle
    {
        protected int width;
        protected int height;
        protected Form form;
        protected float centerX = 200;
        protected float centerY = 200;
        protected Image image;

        public ImageRectangle(Form form)
        {
            this.form = form;
        }
        public int LeftSide() => width / 2;
        public int RightSide() => form.ClientSize.Width - width / 2;
        public int TopSide() => width / 2;
        public int DownSide() => form.ClientSize.Height - width / 2;
        public Image GetImage() => image;
        public Rectangle GetBounds()
        {
            return new Rectangle((int)centerX - width / 2, (int)centerY - height / 2, width, height);
        }
        public PointF GetCenterPoint() => new PointF(centerX, centerY);
    }
}

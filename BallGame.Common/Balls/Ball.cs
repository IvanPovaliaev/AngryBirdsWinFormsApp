using System;
using System.Drawing;
using System.Windows.Forms;

namespace BallGame.Common
{
    public class Ball
    {
        protected Form form;
        protected System.Timers.Timer timer;
        protected float vx = 20;
        protected float vy = 20;
        protected float centerX;
        protected float centerY;
        protected int radius = 10;
        protected Color color;
        protected Random random = new Random();

        public Ball(Form form)
        {
            this.form = form;
            var colorIndex = random.Next(0, ColorsLibrary.GetAll().Count);
            
            color = ColorsLibrary.GetAll()[colorIndex];

            timer = new System.Timers.Timer();
            timer.Interval = 75;
            timer.Elapsed += Move_Tick;
        }
        public void Start() => timer.Start();
        public void Stop() => timer.Close();
        public void AddDissapearEvent(EventHandler dissapearEvent) => timer.Disposed += dissapearEvent;
        public virtual void Show()
        {
            var brush = new SolidBrush(color);
            Draw(brush);
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
        public int LeftSide() => radius;
        public int RightSide() => form.ClientSize.Width - radius;
        public int TopSide() => radius;
        public int DownSide() => form.ClientSize.Height - radius;
        public bool PartiallyOutForm()
        {
            return centerX < LeftSide() || centerX > RightSide() || centerY < TopSide() || centerY > DownSide();
        }
        public bool FullyOutForm()
        {
            return centerX + 2 * radius < LeftSide() || centerX - 2*radius > RightSide() || centerY + 2 * radius < TopSide() || centerY - 2 * radius > DownSide();
        }
        public void Clear()
        {
            var brush = new SolidBrush(form.BackColor);
            Draw(brush);
        }
        public float GetCoordinates(out float y)
        {
            y = centerY;
            return centerX;
        }
        public int GetSize() => radius;
        public double GetTotalVelocity()
        {
            return 1000*Math.Sqrt(vx * vx + vy * vy)/timer.Interval; //px per seconds
        }
        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }
        protected virtual void Move_Tick(object? sender, EventArgs e)
        {
            Move();
            if (FullyOutForm()) timer.Dispose();
        }   
        private void Draw(Brush brush)
        {
            try
            {
                var graphics = form.CreateGraphics();
                var rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);
                graphics.FillEllipse(brush, rectangle);
            }
            catch (ObjectDisposedException)
            {
                Stop();
            }
        }    
    }
}

using System;
using System.Windows.Forms;

namespace BallGame.Common
{
    public abstract class MoveImageRectangle : ImageRectangle
    {
        protected System.Timers.Timer timer;
        protected float vx = -3;
        protected float vy = 15;

        public MoveImageRectangle(Form form) : base(form)
        {
            InitializeTimer();
        }
        public void Start() => timer.Start();
        public void Stop() => timer.Dispose();
        public void AddDissapearEvent(EventHandler dissapearEvent) => timer.Disposed += dissapearEvent;
        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
        }
        protected virtual void Move() => Go();
        protected abstract void Move_Tick(object? sender, EventArgs e);
        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 10;
            timer.Elapsed += Move_Tick;
        }
    }
}

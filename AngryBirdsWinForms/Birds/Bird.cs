using System.Drawing;
using System;
using System.Windows.Forms;
using BallGame.Common;

namespace AngryBirdsWinForms
{
    public class Bird : MoveImageRectangle
    {
        public const string ThrowSoundPath = @"Sounds/AngryBirds_RedThrowSound.wav";
        public Bird(Form form) : base(form)
        {
            image = Properties.Resources.RedBird;
            width = 50;
            height = 50;

            centerX = width/2;
            centerY = form.ClientSize.Height - height/2;         
        }
        public virtual void SetVelocity(PointF point)
        {
            vx = (point.X - centerX)/8;
            vy = (point.Y - centerY)/8;
        }
        public bool FullyOutForm()
        {
            return centerX + width < LeftSide() || centerX - width > RightSide() || centerY - height > DownSide();
        }
        protected override void Move_Tick(object? sender, EventArgs e)
        {
            Move();
            if (FullyOutForm()) Stop();
        }
    }
}

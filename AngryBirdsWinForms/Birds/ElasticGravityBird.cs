using BallGame.Common;
using System.Drawing;
using System.Windows.Forms;

namespace AngryBirdsWinForms
{
    public class ElasticGravityBird : GravityBird
    {
        private float frictionCoefficient = 0.7f;
        private float initialVy;
        public const string HitOnGroundPath = @"Sounds/AngryBirds_RedHitOnGroundSound.wav";
        public ElasticGravityBird(Form form) : base(form)
        {
            initialVy = vy;
        }
        public override void SetVelocity(PointF point)
        {
            base.SetVelocity(point);
            initialVy = vy;
        }
        protected override void Go()
        {
            if (centerY > DownSide())
            {                
                centerY = DownSide();
                vx *= frictionCoefficient;
                if (vx < 0.1f) vx = 0;
                if (initialVy > -0.1f) vy = 0f;
                else
                {                    
                    initialVy *= frictionCoefficient;
                    vy = initialVy;
                    if (vy < -2f) _ = AudioProvider.PlaySoundAsync(HitOnGroundPath, SystemSettings.SoundsVolume);
                }
            }
            if (vx == 0f &&  vy == 0f)
            {
                Stop();
                return;
            }
            base.Go();
        }
    }
}

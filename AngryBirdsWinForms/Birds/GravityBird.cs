using System.Windows.Forms;

namespace AngryBirdsWinForms
{
    public class GravityBird : Bird
    {
        protected float g = 0.4f;
        public GravityBird(Form form) : base(form)
        {
        }
        protected override void Go()
        {
            vy += g;
            base.Go();
        }
    }
}

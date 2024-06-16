using System;
using System.Windows.Forms;

namespace AngryBirdsWinForms
{
    public class RandomPointPig : Pig
    {
        protected Random random;
        public RandomPointPig(Form form) : base(form)
        {
            random = new Random();            
            centerX = random.Next(form.ClientSize.Width/5, RightSide());
            centerY = random.Next(TopSide(), DownSide());
        }
    }
}

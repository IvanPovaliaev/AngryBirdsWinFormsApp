using BallGame.Common;
using System.Windows.Forms;

namespace AngryBirdsWinForms
{
    public class Pig : ImageRectangle
    {
        public const string HittedSoundPath = @"Sounds/AngryBirds_PigsHitted.wav";
        public const string MockertySoundPath = @"Sounds/AngryBirds_PigsMockery.wav";
        public Pig(Form form) : base(form)
        {
            image = Properties.Resources.Pig;
            width = 50;
            height = 50;
        }
    }
}

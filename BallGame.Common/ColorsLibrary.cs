using System.Collections.Generic;
using System.Drawing;

namespace BallGame.Common
{
    public static class ColorsLibrary
    {
        public static List<Color> GetAll()
        {
            var colorsList  = new List<Color>()
            {
                ColorTranslator.FromHtml("#1F598C"),
                ColorTranslator.FromHtml("#398CBF"),
                ColorTranslator.FromHtml("#BDDEFF"),
                ColorTranslator.FromHtml("#F2505D"),
                ColorTranslator.FromHtml("#590202"),
                ColorTranslator.FromHtml("#E9F2A7"),
                ColorTranslator.FromHtml("#3B7302"),
                ColorTranslator.FromHtml("#055902"),
                ColorTranslator.FromHtml("#F29F05"),
                ColorTranslator.FromHtml("#F2C9E0"),
                ColorTranslator.FromHtml("#591B38"),
                ColorTranslator.FromHtml("#7F8994"),
                ColorTranslator.FromHtml("#D9A273"),
                ColorTranslator.FromHtml("#45858C")
            };
            return colorsList;
        }
    }
}

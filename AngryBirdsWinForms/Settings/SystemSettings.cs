using System.Reflection;
using System.Resources;

namespace AngryBirdsWinForms
{
    public static class SystemSettings
    {
        public static int SoundsVolume = 30;
        public static ResourceManager LocalizationResourceManager { get; private set; } = new ResourceManager($"AngryBirdsWinForms.Languages.Russian", Assembly.GetExecutingAssembly());
        public static GameLanguageCodes LanguageCode { get; private set; } = GameLanguageCodes.Ru;

        public static void SetLanguages(GameLanguageCodes languageCodes)
        {
            LanguageCode = languageCodes;
            switch (languageCodes)
            {
                case GameLanguageCodes.Ru:
                    LocalizationResourceManager = new ResourceManager($"AngryBirdsWinForms.Languages.Russian", Assembly.GetExecutingAssembly());
                    break;
                case GameLanguageCodes.En:
                    LocalizationResourceManager = new ResourceManager($"AngryBirdsWinForms.Languages.English", Assembly.GetExecutingAssembly());
                    break;
                case GameLanguageCodes.De:
                    LocalizationResourceManager = new ResourceManager($"AngryBirdsWinForms.Languages.German", Assembly.GetExecutingAssembly());
                    break;
                default:
                    LocalizationResourceManager = new ResourceManager($"AngryBirdsWinForms.Languages.Russian", Assembly.GetExecutingAssembly());
                    break;
            }
        }
    }
}
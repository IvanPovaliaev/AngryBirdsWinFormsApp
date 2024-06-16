using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace AngryBirdsWinForms
{
    public partial class SettingsForm : Form
    {
        private int volumeValue;
        private GameLanguageCodes initialLangCode;
        private Dictionary<GameLanguageCodes, string> languages;

        public SettingsForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            DoubleBuffered = true;
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            initialLangCode = SystemSettings.LanguageCode;
            volumeValue = SystemSettings.SoundsVolume;

            InitializeSoundVolumeTracker();
            InitializeLanguagesComboBox();
            InitializeControlsTranslation();
        }

        private void InitializeLanguagesComboBox()
        {
            languages = new Dictionary<GameLanguageCodes, string>()
            {
                {GameLanguageCodes.Ru, "Русский"},
                {GameLanguageCodes.En, "English"},
                {GameLanguageCodes.De, "Deutsch"}
            };

            var initIndex = 0;
            foreach (var language in languages)
            {
                if (language.Key == SystemSettings.LanguageCode) break;
                initIndex++;
            }

            fileLanguageComboBox.DataSource = new BindingSource(languages, null);
            fileLanguageComboBox.DisplayMember = "Value";
            fileLanguageComboBox.ValueMember = "Key";
            fileLanguageComboBox.SelectedIndex = initIndex;
        }
        private void InitializeSoundVolumeTracker()
        {
            soundVolumeSliderControl.BackColor = Color.FromArgb(50, Color.White);
            soundVolumeSliderControl.Value = SystemSettings.SoundsVolume;
            soundVolumeSliderControl.ValueChanged += (sender, e) => ShowCurrentVolume();
            ShowCurrentVolume();
        }
        private void ShowCurrentVolume()
        {
            volumeValue = soundVolumeSliderControl.Value;
            soundCurrentVolumeLabel.Text = $"{volumeValue}%";
            Invalidate();
        }
        private void acceptButton_Click(object sender, EventArgs e)
        {
            SystemSettings.SoundsVolume = volumeValue;
            Properties.Settings.Default.LastUsedLanguage = (int)SystemSettings.LanguageCode;
            Properties.Settings.Default.Save();
            WinFormsProvider.OpenChildForm(new GameForm());
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            SystemSettings.SetLanguages(initialLangCode);
            WinFormsProvider.OpenChildForm(new GameForm());
        }

        private void InitializeControlsTranslation()
        {
            var languageResManager = SystemSettings.LocalizationResourceManager;
            soundsLevelLabel.Text = languageResManager.GetString("SoundsVolume");
            languageLabel.Text = languageResManager.GetString("Language");
            acceptButton.Text = languageResManager.GetString("AcceptButton");
            cancelButton.Text = languageResManager.GetString("CancelButton");
        }

        private void fileLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedKeyValuePair = (KeyValuePair<GameLanguageCodes, string>)fileLanguageComboBox.SelectedItem;
            SystemSettings.SetLanguages(selectedKeyValuePair.Key);
            InitializeControlsTranslation();
        }


    }
}

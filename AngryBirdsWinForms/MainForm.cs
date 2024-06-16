using BallGame.Common;
using System;

namespace AngryBirdsWinForms
{
    public partial class MainForm : DoubleBufferedForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StaticData.MainForm = this;
            StaticData.ChildFormPanel = childFormPanel;
            SystemSettings.SetLanguages(SystemSettings.LanguageCode);
            WinFormsProvider.OpenChildForm(new GameForm());
        }
    }
}

using System.Windows.Forms;

namespace AngryBirdsWinForms
{
    public static class WinFormsProvider
    {
        public static void OpenChildForm(Form childForm)
        {
            StaticData.ActiveForm?.Close();

            StaticData.ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            StaticData.ChildFormPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}

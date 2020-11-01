using System.Windows.Forms;

namespace Interpol
{
    public partial class CriminalDetails : Form
    {
        User user = new User();
        private int criminalCode;

        public CriminalDetails(int criminalCode)
        {
            InitializeComponent();
            this.criminalCode = criminalCode;
            fillDetails();
            foreach (Form f in Application.OpenForms)
            {
                if (f.Visible == true && f.Name == "GuestForm") buttonEdit.Visible = false;
            }
        }

        private void fillDetails()
        {
            pictureBoxPhoto.Image = user.loadPhoto(criminalCode);
            labelName.Text = user.loadName(criminalCode);
            labelSurname.Text = user.loadSurname(criminalCode);
            labelNickname.Text = user.loadNickname(criminalCode);
            labelGroup.Text = user.loadGroupName(criminalCode);
            labelSpec.Text = user.loadSpec(criminalCode);
            labelResidence.Text = user.loadResidence(criminalCode);
            labelBirthDate.Text = user.loadDate(criminalCode);
            labelBirthPlace.Text = user.loadBirthplace(criminalCode);
            labelCitizenship.Text = user.loadCitizenship(criminalCode);
            labelEyes.Text = user.loadEyes(criminalCode);
            labelHair.Text = user.loadHair(criminalCode);
            labelHeight.Text = user.loadHeight(criminalCode);
            labelLang.Text = user.loadLanguages(criminalCode);
            checkBoxGaveUp.Checked = user.loadGaveUp(criminalCode);
            checkBoxIsDead.Checked = user.loadIsDead(criminalCode);
            labelDeathDate.Text = user.loadDeathDate(criminalCode);
            labelDeathPlace.Text = user.loadDeathPlace(criminalCode);
            labelDeathCircs.Text = user.loadDeathCircs(criminalCode);
            richTextBoxSentence.Text = user.loadSentences(criminalCode);
        }

        private void buttonEdit_Click(object sender, System.EventArgs e)
        {
            EditCriminal ec = new EditCriminal(criminalCode);
            ec.Show();

        }

        private void checkBoxIsDead_CheckedChanged(object sender, System.EventArgs e)
        {
            if (groupBoxDeath.Visible == false) groupBoxDeath.Visible = true;
            else groupBoxDeath.Visible = false;
        }
    }
}

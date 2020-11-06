using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpol
{
    public partial class EditCriminal : Form
    {
        User user = new User();
        static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\cardfile.mdb";
        string fileName = "";

        int criminalCode;
        public EditCriminal(int criminalCode)
        {
            InitializeComponent();
            this.criminalCode = criminalCode;
            fillDetails();
        }

        private void EditCriminal_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cardfileDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.cardfileDataSet.Groups);

        }

        private void fillDetails()
        {
            textBoxName.Text = user.loadName(criminalCode);
            textBoxSurname.Text = user.loadSurname(criminalCode);
            textBoxNickname.Text = user.loadNickname(criminalCode);
            comboBoxGroup.Text = user.loadGroupName(criminalCode);
            textBoxSpec.Text = user.loadSpec(criminalCode);
            textBoxResidence.Text = user.loadResidence(criminalCode);
            dateTimePickerBirth.Text = user.loadDate(criminalCode);
            textBoxBirthPlace.Text = user.loadBirthplace(criminalCode);
            textBoxCitizenship.Text = user.loadCitizenship(criminalCode);
            textBoxEyes.Text = user.loadEyes(criminalCode);
            textBoxHair.Text = user.loadHair(criminalCode);
            numericUpDownHeight.Text = user.loadHeight(criminalCode);
            textBoxLang.Text = user.loadLanguages(criminalCode);
            checkBoxGaveUp.Checked = user.loadGaveUp(criminalCode);
            checkBoxIsDead.Checked = user.loadIsDead(criminalCode);
            dateTimePickerDeath.Text = user.loadDeathDate(criminalCode);
            textBoxDeathPlace.Text = user.loadDeathPlace(criminalCode);
            textBoxDeathCircs.Text = user.loadDeathCircs(criminalCode);
            Sentence[] sentences = displaySentence(criminalCode); 
            foreach (Sentence sentence in sentences)
            {
                flowLayoutPanelSentences.Controls.Add(sentence);
            }

            Sentence sentenceAdd = new Sentence(true);
            sentenceAdd.CriminalCode = criminalCode;
            flowLayoutPanelSentences.Controls.Add(sentenceAdd);

        }

        private void checkBoxIsDead_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBoxDeath.Visible == false) groupBoxDeath.Visible = true;
            else groupBoxDeath.Visible = false;
        }

        private void buttonFileSearch_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    var filePath = openFileDialog.FileName;
                    textBoxFilePath.Text = filePath;
                    fileName = filePath;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            byte[] imageArr;
            MemoryStream memoryStream = new MemoryStream();
            if (fileName.Length > 0)
            {
                Image image = Image.FromFile(fileName);
                image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                imageArr = memoryStream.ToArray();
            }
            else
            {
                imageArr = user.imageArray(criminalCode);
            }
            string infoDead = ", Criminal_death_date = @dd, Criminal_death_place = @dp, Criminal_death_circs = @dc  WHERE Criminal_code = " + criminalCode + "; ";
            string infoAlive = ", Criminal_death_date = NULL, Criminal_death_place = NULL, Criminal_death_circs = NULL  WHERE Criminal_code = " + criminalCode + "; ";
            string commText = "UPDATE Criminals SET Criminal_name = ?, Criminal_surname = ?, Criminal_nickname = ?, " +
                "Criminal_birth_date = ?, Criminal_height = ?, Criminal_eyes = ?, Criminal_hair = ?, Criminal_citizenship = ?, Criminal_birthplace = ?," +
                " Criminal_residence = ?, Criminal_languages = ?, Criminal_spec = ?, Criminal_photo = ?, Group_code = ?, Criminal_gave_up = ?, " +
                "Criminal_is_dead = @isdead";

            if (checkBoxIsDead.Checked == false)commText += infoAlive;
            else commText += infoDead;
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand(commText, conn);
            command.Parameters.AddWithValue(@"Criminal_name", textBoxName.Text.ToString());
            command.Parameters.AddWithValue(@"Criminal_surname", textBoxSurname.Text.ToString());
            command.Parameters.AddWithValue(@"Criminal_nickname", textBoxNickname.Text.ToString());
            command.Parameters.Add(new OleDbParameter(@"Criminal_birth_date", dateTimePickerBirth.Value));
            command.Parameters.Add(@"Criminal_height", OleDbType.Integer);
            command.Parameters[@"Criminal_height"].Value = Convert.ToInt32(numericUpDownHeight.Value);
            command.Parameters.AddWithValue(@"Criminal_eyes", textBoxEyes.Text.ToString());
            command.Parameters.AddWithValue(@"Criminal_hair", textBoxHair.Text.ToString());
            command.Parameters.AddWithValue(@"Criminal_citizenship", textBoxCitizenship.Text.ToString());
            command.Parameters.AddWithValue(@"Criminal_birthplace", textBoxBirthPlace.Text.ToString());
            command.Parameters.AddWithValue(@"Criminal_residence", textBoxResidence.Text.ToString());
            command.Parameters.AddWithValue(@"Criminal_languages", textBoxLang.Text.ToString());
            command.Parameters.AddWithValue(@"Criminal_spec", textBoxSpec.Text.ToString());
            command.Parameters.AddWithValue(@"Criminal_photo", imageArr);
            command.Parameters.Add(@"Group_code", OleDbType.Integer);
            command.Parameters[@"Group_code"].Value = Convert.ToInt32(comboBoxGroup.SelectedValue);
            command.Parameters.Add(@"Criminal_gave_up", OleDbType.Boolean);
            command.Parameters[@"Criminal_gave_up"].Value = Convert.ToBoolean(checkBoxGaveUp.Checked);
            command.Parameters.Add("@isdead", OleDbType.Boolean);
            command.Parameters["@isdead"].Value = Convert.ToBoolean(checkBoxIsDead.Checked);
            command.Parameters.Add(new OleDbParameter("@dd", dateTimePickerDeath.Value));
            command.Parameters.AddWithValue("@dp", textBoxDeathPlace.Text);
            command.Parameters.AddWithValue("@dc", textBoxDeathCircs.Text);
            conn.Open();
            if (MessageBox.Show("Изменение записи в таблице Преступники", "Подтвердите изменения", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    command.ExecuteNonQuery();
                }catch(Exception ex) { MessageBox.Show("Ошибка изменения записи."); }
            }
            conn.Close();
            memoryStream.Dispose();
        }

        private Sentence[] displaySentence(int criminalCode)
        {
            byte sentences = 0;
            Sentence[] sentence = new Sentence[127];
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand commandSentence = new OleDbCommand("SELECT Sentence_date, Release_date, Notation, Sentence_code, Crime_code FROM Sentence WHERE Criminal_code = " + criminalCode, conn);
            conn.Open();
            OleDbDataReader readerSentence = commandSentence.ExecuteReader();
            while (readerSentence.Read())
            {
                int Crime_code = Convert.ToInt32(readerSentence[4]);
                OleDbCommand commandCrime = new OleDbCommand("SELECT Crime_type, Crime_description, Crime_term FROM Crimes WHERE Crime_code = " + Crime_code, conn);
                OleDbDataReader readerCrime = commandCrime.ExecuteReader();
                readerCrime.Read();
                sentence[sentences] = new Sentence();
                sentence[sentences].CrimeCode = Crime_code;
                sentence[sentences].crimeType =  Convert.ToString(readerCrime[0]);
                sentence[sentences].CrimeDesc = Convert.ToString(readerCrime[1]);
                sentence[sentences].CrimeTerm = Convert.ToString(readerCrime[2]);
                sentence[sentences].SentenceDate = Convert.ToString(readerSentence[0]);
                sentence[sentences].ReleaseDate = Convert.ToString(readerSentence[1]);
                sentence[sentences].Notation = Convert.ToString(readerSentence[2]);
                sentence[sentences].sentenceCode = Convert.ToInt32(readerSentence[3]);
                sentences++;
                readerCrime.Close();
            }
            readerSentence.Close();
            conn.Close();
            return sentence;
        }

    }
}

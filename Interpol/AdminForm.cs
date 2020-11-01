using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Interpol
{
    public partial class AdminForm : Form
    {
        Admin admin = new Admin();
        static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\cardfile.mdb";
        string fileName = @".\default-user-image.png";
        public AdminForm()
        {
            InitializeComponent();
            this.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cardfileDataSet.Criminals". При необходимости она может быть перемещена или удалена.
            this.criminalsTableAdapter.Fill(this.cardfileDataSet.Criminals);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cardfileDataSet.Groups". При необходимости она может быть перемещена или удалена.
            this.groupsTableAdapter.Fill(this.cardfileDataSet.Groups);
            cardfileDataSetTableAdapters.CriminalsTableAdapter criminalsTableAdapter = new cardfileDataSetTableAdapters.CriminalsTableAdapter();
            criminalsTableAdapter.GetData();

            displayCriminals();

            List<Form> openForms = new List<Form>();
            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                Console.WriteLine(f.Name);
            }

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name == "AuthForm") f.Show();
                else f.Hide();
            }
        }

            private void buttonMore_Click(object sender, EventArgs e)
        {
            if (panelMore.Visible == true)
                panelMore.Visible = false;
            else panelMore.Visible = true;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {

        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void displayCriminals()
        {
            Criminal[] criminals = admin.getAliveCriminals();
            foreach (Criminal criminal in criminals)
            {
                flowLayoutPanel.Controls.Add(criminal);
            }
        }


        private void buttonTableGaveUp_Click(object sender, EventArgs e)
        {
            panelAddCriminal.Visible = false;
            flowLayoutPanel.Controls.Clear();
            int criminalCode = admin.getFirstCriminalCode();
            Criminal[] criminals = new Criminal[1000000];
            int criminal = 0;
            do
            {
                if (admin.loadGaveUp(criminalCode) == true)
                {
                    criminals[criminal] = new Criminal
                    {
                        name = admin.loadName(criminalCode),
                        surname = admin.loadSurname(criminalCode),
                        nickname = admin.loadNickname(criminalCode),
                        specialization = admin.loadSpec(criminalCode),
                        residence = admin.loadResidence(criminalCode),
                        date = admin.loadDate(criminalCode),
                        image = admin.loadPhoto(criminalCode),
                        code = criminalCode
                    };
                    flowLayoutPanel.Controls.Add(criminals[criminal]);
                }
                criminal++;
                criminalCode++;
            } while (criminal < admin.getNumberOfRows());
        }

        private void buttonTableDead_Click(object sender, EventArgs e)
        {
            panelAddCriminal.Visible = false;
            flowLayoutPanel.Controls.Clear();
            int criminalCode = admin.getFirstCriminalCode();
            Criminal[] criminals = new Criminal[1000000];
            int criminal = 0;
            do
            {
                if (admin.loadIsDead(criminalCode) == true)
                {
                    criminals[criminal] = new Criminal
                    {
                        name = admin.loadName(criminalCode),
                        surname = admin.loadSurname(criminalCode),
                        nickname = admin.loadNickname(criminalCode),
                        specialization = admin.loadSpec(criminalCode),
                        residence = admin.loadResidence(criminalCode),
                        date = admin.loadDate(criminalCode),
                        image = admin.loadPhoto(criminalCode),
                        code = criminalCode
                    };
                    flowLayoutPanel.Controls.Add(criminals[criminal]);
                }
                criminal++;
                criminalCode++;
            } while (criminal < admin.getNumberOfRows());
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            panelAddCriminal.Visible = false;
            flowLayoutPanel.Controls.Clear();
            displayCriminals();
        }

        private void buttonAddCriminal_Click(object sender, EventArgs e)
        {
            if (panelAddCriminal.Visible == true)
                panelAddCriminal.Visible = false;
            else panelAddCriminal.Visible = true;
        }

        private void buttonUploadPhoto_Click(object sender, EventArgs e)
        {
            getFileDir();
        }

        private void getFileDir()
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
                    labelFilePath.Text = filePath;
                    fileName = filePath;
                }
            }
        }


        private void insertCriminal()
        {
             
            MemoryStream memoryStream = new MemoryStream();
            Image image = Image.FromFile(fileName);
            image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
            string deathInfo = ", Criminal_is_dead, Criminal_death_date, Criminal_death_place, Criminal_death_circs) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?); ";
            string noDeathInfo = ") VALUES(?,?,?,?,?,?,?,?,?,?,?,?,?,?,?); ";
            string commText = "INSERT INTO Criminals (Criminal_name, Criminal_surname, Criminal_nickname, " +
                "Criminal_birth_date, Criminal_height, Criminal_eyes, Criminal_hair, Criminal_citizenship, Criminal_birthplace," +
                " Criminal_residence, Criminal_languages, Criminal_spec, Criminal_photo, Group_code, Criminal_gave_up";

            if (checkBoxDead.Checked == true) commText += deathInfo;
            else commText += noDeathInfo;
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
            command.Parameters.AddWithValue(@"Criminal_photo", memoryStream.ToArray());
            command.Parameters.Add(@"Group_code", OleDbType.Integer);
            command.Parameters[@"Group_code"].Value = Convert.ToInt32(comboBoxGroups.SelectedValue);
            command.Parameters.Add(@"Criminal_gave_up", OleDbType.Boolean);
            command.Parameters[@"Criminal_gave_up"].Value = Convert.ToBoolean(checkBoxGaveUp.Checked);
            command.Parameters.Add(@"Criminal_is_dead", OleDbType.Boolean);
            command.Parameters[@"Criminal_is_dead"].Value = Convert.ToBoolean(checkBoxDead.Checked);
            command.Parameters.AddWithValue(@"Criminal_death_date", textBoxDeathDate.Text.ToString());
            command.Parameters.Add(new OleDbParameter(@"Criminal_death_place", textBoxDeathPlace.Text.ToString()));
            command.Parameters.AddWithValue(@"Criminal_death_circs", textBoxDeathCircs.Text.ToString());
            conn.Open();
            try
            {
                command.ExecuteNonQuery();
            }catch(Exception ex) { MessageBox.Show("Ошибка!"); }
            conn.Close();
            memoryStream.Dispose();
        }

        private void buttonInsertCriminal_Click(object sender, EventArgs e)
        {
            insertCriminal();
            textBoxName.ResetText();
            textBoxSurname.ResetText();
            textBoxNickname.ResetText();
            dateTimePickerBirth.ResetText();
            numericUpDownHeight.ResetText();
            textBoxEyes.ResetText();
            textBoxHair.ResetText();
            textBoxCitizenship.ResetText();
            textBoxBirthPlace.ResetText();
            textBoxResidence.ResetText();
            textBoxLang.ResetText();
            textBoxSpec.ResetText();
            comboBoxGroups.ResetText();
            checkBoxGaveUp.ResetText();
            checkBoxDead.ResetText();
            textBoxDeathDate.ResetText();
            textBoxDeathPlace.ResetText();
            textBoxDeathCircs.ResetText();
            labelFilePath.ResetText();
            panelAddCriminal.Visible = false;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.textBoxDeathDate.Text = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void buttonCalendar_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == false)
            {
                monthCalendar1.Visible = true;
                buttonCalendar.Text = "Скрыть";
            }
            else
            {
                monthCalendar1.Visible = false;
                buttonCalendar.Text = "Выбрать";
            }
        }

        private void checkBoxDead_CheckedChanged(object sender, EventArgs e)
        {
            if (groupBoxDeath.Visible == false) groupBoxDeath.Visible = true;
            else groupBoxDeath.Visible = false;
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            byte group = 0;
            Group[] groups = new Group[127];
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand commandGroups = new OleDbCommand("SELECT Group_code, Group_name, Group_leader, Group_info, Group_activity_years FROM Groups ;", conn);
            conn.Open();
            OleDbDataReader readerGroups = commandGroups.ExecuteReader();
            while (readerGroups.Read())
            {
                groups[group] = new Group();
                groups[group].GroupCode = Convert.ToInt32(readerGroups[0]);
                groups[group].GroupName = Convert.ToString(readerGroups[1]);
                groups[group].GroupLeader = Convert.ToString(readerGroups[2]);
                groups[group].GroupInfo = Convert.ToString(readerGroups[3]);
                groups[group].GroupActYears = Convert.ToString(readerGroups[4]);
                groups[group].loadLinks(Convert.ToInt32(readerGroups[0]));
                flowLayoutPanel.Controls.Add(groups[group]);
                group++;
            }
            readerGroups.Close();
            conn.Close();
            Group addGroup = new Group(true);
            flowLayoutPanel.Controls.Add(addGroup);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Scrypt;

namespace Interpol
{
    public partial class AdminForm : Form
    {
        User user = new User();
        private string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\cardfile.mdb";
        private string path = @".\users.dat";
        private string fileName = @".\default-user-image.png";
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

        private void buttonShowAddUser_Click(object sender, EventArgs e)
        {
            panelAddCrime.Visible = false;
            panelAddCriminal.Visible = false;
            panelAddUser.Visible = true;
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void displayCriminals()
        {
            Criminal[] criminals = user.getAliveCriminals();
            foreach (Criminal criminal in criminals)
            {
                flowLayoutPanel.Controls.Add(criminal);
            }
        }

        private void buttonTableGaveUp_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = false;
            panelAddCrime.Visible = false;
            panelAddCriminal.Visible = false;
            flowLayoutPanel.Controls.Clear();
            Criminal[] criminals = user.getGaveUpCriminals();
            foreach (Criminal criminal in criminals)
            {
                flowLayoutPanel.Controls.Add(criminal);
            }
        }

        private void buttonTableDead_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = false;
            panelAddCrime.Visible = false;
            panelAddCriminal.Visible = false;
            flowLayoutPanel.Controls.Clear();
            Criminal[] criminals = user.getDeadCriminals();
            foreach (Criminal criminal in criminals)
            {
                flowLayoutPanel.Controls.Add(criminal);
            }
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = false;
            panelAddCrime.Visible = false;
            panelAddCriminal.Visible = false;
            flowLayoutPanel.Controls.Clear();
            displayCriminals();
        }

        private void buttonAddCriminal_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = false;
            panelAddCrime.Visible = false;
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
            if (MessageBox.Show("Добавление записи в таблицу Преступники", "Добавить запись?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show("Ошибка при добавлении записи."); }
            }
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
            panelAddCriminal.Visible = false;
            panelAddCrime.Visible = false;
            panelAddUser.Visible = false;
            flowLayoutPanel.Controls.Clear();
            Group[] groups = user.getGroups();
            foreach (Group group in groups)
            {
                flowLayoutPanel.Controls.Add(group);
            }
            Group addGroup = new Group(true);
            flowLayoutPanel.Controls.Add(addGroup);
        }

        private void flowLayoutPanel_Click(object sender, EventArgs e)
        {
            panelAddCriminal.Visible = false;
            panelAddCrime.Visible = false;
            panelAddUser.Visible = false;
        }

        private void buttonAddCrime_Click(object sender, EventArgs e)
        {
            panelAddCrime.Visible = true;
            panelAddCriminal.Visible = false;
            panelAddUser.Visible = false;

        }

        private void buttonHideAddCrimeMenu_Click(object sender, EventArgs e)
        {
            panelAddCrime.Visible = false;
        }

        private void buttonInsertCrime_Click(object sender, EventArgs e)
        {
            string comm = "INSERT INTO Crimes (Crime_type, Crime_term, Crime_description) VALUES (?,?,?);";
            OleDbConnection connection = new OleDbConnection(connString);
            OleDbCommand command = new OleDbCommand(comm, connection);
            command.Parameters.AddWithValue(@"Crime_type", textBoxCrimeType.Text.ToString());
            command.Parameters.AddWithValue(@"Crime_term", textBoxCrimeTerm.Text.ToString());
            command.Parameters.AddWithValue(@"Crime_desc", textBoxCrimeDesc.Text.ToString());
            connection.Open();
            if (MessageBox.Show("Добавление записи в таблицу Преступления", "Добавить запись?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show("Ошибка при добавлении записи."); }
            }
            connection.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            panelAddCriminal.Visible = false;
            panelAddCrime.Visible = false;
            panelAddUser.Visible = false;
            panelSearch.Visible = true;
            string[] columName = { "Criminal_code", "Criminal_name", "Criminal_surname", "Criminal_nickname",
                                    "Criminal_birth_date", "Criminal_height", "Criminal_eyes", "Criminal_hair",
                                    "Criminal_citizenship", "Criminal_birthplace", "Criminal_residence", "Criminal_languages",
                                    "Criminal_death_date","Criminal_death_place","Criminal_spec"};
            for (byte i = 0; i < columName.Length; i++)
            {
                Criminal[] criminals = user.searchResult(columName[i] + " LIKE '%" + textBoxSearch.Text.ToString() + "%' ");
                foreach (Criminal criminal in criminals)
                {
                    flowLayoutPanel.Controls.Add(criminal);
                }
            }

        }

        private void buttonHideAddUser_Click(object sender, EventArgs e)
        {
            panelAddUser.Visible = false;
        }

        private void buttonShowDeleteUser_Click(object sender, EventArgs e)
        {
            if (labelUser.Text == "Добавление пользователя:")
            {
                groupBoxLevel.Visible = false;
                buttonShowDeleteUser.Text = "Добавить пользователя";
                labelUser.Text = "Удаление пользователя:";
                buttonDeleteUser.Visible = true;
                buttonAddUser.Visible = false;
            }
            else
            {
                groupBoxLevel.Visible = true;
                buttonShowDeleteUser.Text = "Удалить пользователя";
                labelUser.Text = "Добавление пользователя:";
                buttonDeleteUser.Visible = false;
                buttonAddUser.Visible = true;
            }
        }

        private bool checkLogin(string[] logins, string login)
        {
            foreach (string line in logins)
            {
                if((line.Split(':')[0]) == login)
                {
                    return true;
                }
            }
            return false;
        }

        async Task addUser(string login, string password, byte level)
        {
            if ((textBoxLogin.TextLength != 0) && (textBoxPassword.TextLength != 0)) {
                ScryptEncoder encoder = new ScryptEncoder();
                string hashedPassw = encoder.Encode(password);
                string[] lines;
                if (!File.Exists(path))
                {
                    MessageBox.Show("File not found.");
                }
                else
                {
                    lines = File.ReadAllLines(path);
                    if (!checkLogin(lines, login))
                    {
                        using (FileStream fstream = new FileStream(path, FileMode.Append))
                        {
                            byte[] array = System.Text.Encoding.Default.GetBytes(login + ":" + hashedPassw + ":" + level + Environment.NewLine);
                            // асинхронная запись массива байтов в файл
                            await fstream.WriteAsync(array, 0, array.Length);
                            fstream.Close();
                        }
                    }
                    else MessageBox.Show("Пользователь с таким логином существует.");
                }
            }
        }

        private async void buttonAddUser_Click(object sender, EventArgs e)
        {
            byte selectedLevel = 1;
            if (radioButtonLevel2.Checked == true) selectedLevel = 2;
            await addUser(textBoxLogin.Text.ToString(), textBoxPassword.Text.ToString(), selectedLevel);
            textBoxLogin.Clear();
            textBoxPassword.Clear();
            radioButtonLevel1.Checked = true;
        }

        private void buttonShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
        }

        private void buttonShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        void deleteUser(string login, string password)
        {
            ScryptEncoder encoder = new ScryptEncoder();
            string[] lines;
            if (!File.Exists(path))
            {
                MessageBox.Show("File not found.");
            }
            else
            {
                string tempFile = Path.GetTempFileName();
                using (var sr = new StreamReader(path))
                using (var sw = new StreamWriter(tempFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        try
                        {
                            string[] arr = line.Split(':');
                            string hashedPassword = arr[1];
                            if ((login == arr[0]) && encoder.Compare(password, hashedPassword))
                            {
                                MessageBox.Show(login + " был удален.");
                                continue;
                            }
                            else sw.WriteLine(line);
                        }catch(Exception ex) { MessageBox.Show("При удалении"); }
                    }
                }
                File.Delete(path);
                File.Move(tempFile, path);
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            deleteUser(textBoxLogin.Text.ToString(), textBoxPassword.Text.ToString());
            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }
    }
}

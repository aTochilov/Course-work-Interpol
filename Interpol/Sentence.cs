using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Interpol.cardfileDataSetTableAdapters;

namespace Interpol
{
    public partial class Sentence : UserControl
    {
        bool isAddForm = false;
        int _criminalCode;
        int _crimeCode;
        int _sentenceCode;
        string _crimeType;
        string _crimeTerm;
        string _crimeDesc;
        string _sentenceDate;
        string _releaseDate;
        string _notation;

        public Sentence()
        {
            InitializeComponent();
        }

        public Sentence(bool isAddForm)
        {
            this.isAddForm = isAddForm;
            InitializeComponent();
            labelSentenceCode.Visible = false;
            buttonSave.Text = "Добавить";
            textBoxCrime.Visible = false;
            comboBoxCrimes.Visible = true;
            richTextBoxDesc.Enabled = false;
            textBoxTerm.Enabled = false;
        }

        public string ReleaseDate { get => _releaseDate; set { _releaseDate = value; dateTimePickerRelease.Value = (DateTime)new DateTimeConverter().ConvertFrom(value); } }
        public string ReleaseDateAdd { get => _releaseDate; set { _releaseDate = value; } }

        public string SentenceDate { get => _sentenceDate; set { _sentenceDate = value; dateTimePickerSentence.Value = (DateTime)new DateTimeConverter().ConvertFrom(value); } }
        public string SentenceDateAdd { get => _sentenceDate; set { _sentenceDate = value; } }

        public string Notation { get => _notation; set { _notation = value; richTextBoxNotation.Text = value; } }
        public string NotationAdd { get => _notation; set { _notation = value; } }

        public int sentenceCode { get { return _sentenceCode; } set { _sentenceCode = value; labelSentenceCode.Text = Convert.ToString(value); } }

        public string crimeType { get { return _crimeType; } set { _crimeType = value; textBoxCrime.Text = value; }}
        public string crimeTypeAdd { get { return _crimeType; } set { _crimeType = value; } }

        public string CrimeTerm { get => _crimeTerm; set { _crimeTerm = value; textBoxTerm.Text = value; } }
        public string CrimeTermAdd { get => _crimeTerm; set { _crimeTerm = value; } }

        public string CrimeDesc { get => _crimeDesc; set { _crimeDesc = value; richTextBoxDesc.Text = value; } }
        public string CrimeDescAdd { get => _crimeDesc; set { _crimeDesc = value; } }

        public int CrimeCode { get => _crimeCode; set => _crimeCode = value; }
        public int CriminalCode { get => _criminalCode; set => _criminalCode = value; }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!isAddForm)
            {
                string commText = "UPDATE Crimes SET Crimes.Crime_type = @ctype, Crimes.Crime_description = @cd, Crimes.Crime_term = @cterm WHERE(((Crimes.Crime_code) = " + CrimeCode + " ));";

                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\cardfile.mdb");
                OleDbCommand command = new OleDbCommand(commText, conn);
                command.Parameters.AddWithValue("@ctype", textBoxCrime.Text.ToString());
                command.Parameters.AddWithValue("@cd", richTextBoxDesc.Text.ToString());
                command.Parameters.AddWithValue("@cterm", textBoxTerm.Text.ToString());

                string commText1 = "UPDATE Sentence SET Sentence.Sentence_date = @sd, Sentence.Release_date = @rd, Sentence.Notation = @notation WHERE(((Sentence.Sentence_code) = " + sentenceCode + " ));";

                OleDbCommand command1 = new OleDbCommand(commText1, conn);
                command1.Parameters.AddWithValue("@sd", dateTimePickerSentence.Value.ToString());
                command1.Parameters.AddWithValue("@rd", dateTimePickerRelease.Value.ToString());
                command1.Parameters.AddWithValue("@notation", richTextBoxNotation.Text);
                conn.Open();
                if (MessageBox.Show("Изменение записи в таблице Группировки", "Подтвердите изменения", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        command1.ExecuteNonQuery();
                        command.ExecuteNonQuery();
                    }catch(Exception ex) { MessageBox.Show("Ошибка редактирования записи."); }
                }
                conn.Close();
            }
            else
            {
                addSentence();
            }
        }

        private void addSentence()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\cardfile.mdb");
            OleDbCommand com = new OleDbCommand("SELECT @@IDENTITY", conn);
            string commText1 = "INSERT INTO Sentence (Sentence_date, Release_date, Notation, Criminal_code, Crime_code) VALUES (?,?,?,?,?);";
            conn.Open();
            OleDbCommand command1 = new OleDbCommand(commText1, conn);
            command1.Parameters.AddWithValue("@Sentence_date", dateTimePickerSentence.Value.ToString());
            command1.Parameters.AddWithValue("@Release_date", dateTimePickerRelease.Value.ToString());
            command1.Parameters.AddWithValue("@Notation", richTextBoxNotation.Text);
            command1.Parameters.AddWithValue(@"Criminal_code", CriminalCode);
            command1.Parameters.AddWithValue(@"Criminal_code", comboBoxCrimes.SelectedValue);
            if (MessageBox.Show("Изменение записи в таблице Группировки", "Подтвердите изменения", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    command1.ExecuteNonQuery();
                }
                catch (Exception ex) { MessageBox.Show("Ошибка редактирования записи."); }
            }
            conn.Close();
        }

        private void Sentence_Load(object sender, EventArgs e)
        {
            this.crimesTableAdapter.Fill(cardfileDataSet.Crimes);
        }
    }
}
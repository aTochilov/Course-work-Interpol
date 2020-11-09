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

namespace Interpol
{
    public partial class GroupLink : UserControl
    {


        static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\cardfile.mdb";
        bool addLink = false;
        int groupCode;
        string link;

        public GroupLink(int groupCode)
        {
            InitializeComponent();
            this.groupCode = groupCode;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Visible == true && f.Name == "GuestForm") buttonEdit.Visible = false;
            }
        }
        public GroupLink(bool addLink, int groupCode)
        {
            InitializeComponent();
            this.groupCode = groupCode;
            linkLabel.Visible = false;
            textBox.Visible = true;
            buttonEdit.Visible = false;
            buttonSave.Visible = true;
            buttonSave.Text = "Добавить";
            this.addLink = addLink;
        }

        public string Link { get => link; set { link = value; linkLabel.Text = value; } }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (linkLabel.Visible == false)
            {
                textBox.Visible = false;
                buttonSave.Visible = false;
                linkLabel.Visible = true;
            }
            else
            {
                textBox.Text = link;
                textBox.Visible = true;
                buttonSave.Visible = true;
                linkLabel.Visible = false;
            }
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Link);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!addLink)
            {
                string commText = "UPDATE Group_link SET Group_link = ? WHERE Group_code = " + groupCode + "; ";

                OleDbConnection conn = new OleDbConnection(connString);
                OleDbCommand command = new OleDbCommand(commText, conn);
                command.Parameters.AddWithValue(@"Group_link", textBox.Text.ToString());
                conn.Open();
                try
                {
                    command.ExecuteNonQuery();
                    linkLabel.Text = textBox.Text;
                    textBox.Visible = false;
                    linkLabel.Visible = true;
                    buttonSave.Visible = false;
                }
                catch (Exception ex) { MessageBox.Show("Не удалось обновить."); }
                conn.Close();
            }
            else
            {
                string commText = "INSERT INTO Group_link (Group_link, Group_code) VALUES (?,?); ";

                OleDbConnection conn = new OleDbConnection(connString);
                OleDbCommand command = new OleDbCommand(commText, conn);
                command.Parameters.AddWithValue(@"Group_link", textBox.Text.ToString());
                command.Parameters.AddWithValue(@"Group_code", groupCode);
                conn.Open();
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Добавлена новая ссылка.");
                }
                catch (Exception ex) { MessageBox.Show("Не удалось добавить."); }
                conn.Close();
            }
        }
    }
}

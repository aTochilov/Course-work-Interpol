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
    public partial class Group : UserControl
    {
        bool addGroup = false;
        
        static string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\cardfile.mdb";

        public Group()
        {
            InitializeComponent();
        }
        public Group(bool isAddGroup)
        {
            this.addGroup = isAddGroup;
            InitializeComponent();
            buttonEdit.Visible = false;
            buttonSave.Visible = true;
            textBoxActYears.Enabled = true;
            textBoxLeader.Enabled = true;
            textBoxName.Enabled = true;
            textBoxNotation.Enabled = true;
        }

        int groupCode;
        string groupLeader;
        string groupName;
        string groupInfo;
        string groupActYears;

        public int GroupCode { get => groupCode; set { groupCode = value; labelCode.Text = value.ToString(); } }
        public string GroupLeader { get => groupLeader; set { groupLeader = value; textBoxLeader.Text = value; } }
        public string GroupName { get => groupName; set { groupName = value; textBoxName.Text = value;  } }
        public string GroupInfo { get => groupInfo; set { groupInfo = value; textBoxNotation.Text = value; } }
        public string GroupActYears { get => groupActYears; set { groupActYears = value; textBoxActYears.Text = value; } }

        public void loadLinks(int groupCode)
        {
            byte link = 0;
            GroupLink[] links = new GroupLink[127];
            OleDbConnection conn = new OleDbConnection(connString);
            OleDbCommand commandGroups = new OleDbCommand("SELECT Group_link FROM Group_link WHERE Group_code = " + groupCode, conn);
            conn.Open();
            OleDbDataReader readerGroups = commandGroups.ExecuteReader();
            while (readerGroups.Read())
            {
                links[link] = new GroupLink(groupCode);
                links[link].Link = Convert.ToString(readerGroups[0]);
                flowLayoutPanel.Controls.Add(links[link]);
                link++;
            }
            readerGroups.Close();
            conn.Close();
            loadAddLink(groupCode);
        }

        public void loadAddLink(int groupCode)
        {
            GroupLink addLink = new GroupLink(true, groupCode);
            flowLayoutPanel.Controls.Add(addLink);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxActYears.Enabled = true;
            textBoxLeader.Enabled = true;
            textBoxName.Enabled = true;
            textBoxNotation.Enabled = true;
            buttonSave.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!addGroup)
            {
                string commText = "UPDATE Groups SET Group_name = ?, Group_leader = ?, Group_info = ?, " +
                    "Group_activity_years = ? WHERE Group_code = " + groupCode + "; ";

                OleDbConnection conn = new OleDbConnection(connString);
                OleDbCommand command = new OleDbCommand(commText, conn);
                command.Parameters.AddWithValue(@"Group_name", textBoxName.Text.ToString());
                command.Parameters.AddWithValue(@"Group_leader", textBoxLeader.Text.ToString());
                command.Parameters.AddWithValue(@"Group_info", textBoxNotation.Text.ToString());
                command.Parameters.AddWithValue(@"Group_activity_years", textBoxActYears.Text.ToString());
                conn.Open();
                if (MessageBox.Show("Изменение записи в таблице Группировки", "Подтвердите изменения", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex) { MessageBox.Show("Не удалось обновить запись."); }
                    conn.Close();
                }
            }
            else
            {
                string commText = "INSERT INTO Groups (Group_name, Group_leader, Group_info, Group_activity_years) VALUES (?,?,?,?); ";
                string commTxt = "SELECT @@Identity;";
                OleDbConnection conn = new OleDbConnection(connString);
                OleDbCommand command = new OleDbCommand(commText, conn);
                OleDbCommand comm = new OleDbCommand(commTxt, conn);
                command.Parameters.AddWithValue(@"Group_name", textBoxName.Text.ToString());
                command.Parameters.AddWithValue(@"Group_leader", textBoxLeader.Text.ToString());
                command.Parameters.AddWithValue(@"Group_info", textBoxNotation.Text.ToString());
                command.Parameters.AddWithValue(@"Group_activity_years", textBoxActYears.Text.ToString());
                conn.Open();
                if (MessageBox.Show("Добавление записи в таблицу Группировка", "Подтвердите добавление", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        this.groupCode = Convert.ToInt32(comm.ExecuteScalar());
                    }
                    catch (Exception ex) { MessageBox.Show("Не удалось добавить запись."); }
                }
                conn.Close();
                loadAddLink(groupCode);
            }
        }
    }
}

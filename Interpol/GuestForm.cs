using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interpol
{
    public partial class GuestForm : Form
    {
        User user = new User();
        

        public GuestForm()
        {
            InitializeComponent();
            this.Show();
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            displayCriminals();
            
        }

        private void GuestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        private void displayCriminals()
        {
            Criminal[] criminals = user.getAliveCriminals();
            foreach (Criminal criminal in criminals)
            {
                flowLayoutPanelCriminals.Controls.Add(criminal);
            }

        }

        private void buttonTableGaveUp_Click(object sender, EventArgs e)
        {
            flowLayoutPanelCriminals.Controls.Clear();
            Criminal[] criminals = user.getGaveUpCriminals();
            foreach (Criminal criminal in criminals)
            {
                flowLayoutPanelCriminals.Controls.Add(criminal);
            }
        }

        private void buttonTableDead_Click(object sender, EventArgs e)
        {
            flowLayoutPanelCriminals.Controls.Clear();
            Criminal[] criminals = user.getDeadCriminals();
            foreach (Criminal criminal in criminals)
            {
                flowLayoutPanelCriminals.Controls.Add(criminal);
            }
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            flowLayoutPanelCriminals.Controls.Clear();
            displayCriminals();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            flowLayoutPanelCriminals.Controls.Clear();
            Group[] groups = user.getGroups();
            foreach (Group group in groups)
            {
                flowLayoutPanelCriminals.Controls.Add(group);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            flowLayoutPanelCriminals.Controls.Clear();
            string[] columName = { "Criminal_code", "Criminal_name", "Criminal_surname", "Criminal_nickname",
                                    "Criminal_birth_date", "Criminal_height", "Criminal_eyes", "Criminal_hair",
                                    "Criminal_citizenship", "Criminal_birthplace", "Criminal_residence", "Criminal_languages",
                                    "Criminal_death_date","Criminal_death_place","Criminal_spec"};
            for (byte i = 0; i < columName.Length; i++)
            {
                Criminal[] criminals = user.searchResult(columName[i] + " LIKE '%" + textBoxSearch.Text.ToString() + "%' ");
                foreach (Criminal criminal in criminals)
                {
                    flowLayoutPanelCriminals.Controls.Add(criminal);
                }
            }
        }
    }
}

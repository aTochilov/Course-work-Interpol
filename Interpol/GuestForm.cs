using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
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
            int criminalCode = user.getFirstCriminalCode();
            Criminal[] criminals = new Criminal[1000000];
            int criminal = 0;
            do
            {
                if (user.loadGaveUp(criminalCode) == true)
                {
                    criminals[criminal] = new Criminal
                    {
                        name = user.loadName(criminalCode),
                        surname = user.loadSurname(criminalCode),
                        nickname = user.loadNickname(criminalCode),
                        specialization = user.loadSpec(criminalCode),
                        residence = user.loadResidence(criminalCode),
                        date = user.loadDate(criminalCode),
                        image = user.loadPhoto(criminalCode),
                        code = criminalCode
                    };
                    Console.WriteLine(criminalCode);
                    flowLayoutPanelCriminals.Controls.Add(criminals[criminal]); 
                }
                criminal++;
                criminalCode++;
            } while (criminal < user.getNumberOfRows());
        }

        private void buttonTableDead_Click(object sender, EventArgs e)
        {
            flowLayoutPanelCriminals.Controls.Clear();
            int criminalCode = user.getFirstCriminalCode();
            Criminal[] criminals = new Criminal[1000000];
            int criminal = 0;
            do
            {
                if (user.loadIsDead(criminalCode) == true)
                {
                    criminals[criminal] = new Criminal
                    {
                        name = user.loadName(criminalCode),
                        surname = user.loadSurname(criminalCode),
                        nickname = user.loadNickname(criminalCode),
                        specialization = user.loadSpec(criminalCode),
                        residence = user.loadResidence(criminalCode),
                        date = user.loadDate(criminalCode),
                        image = user.loadPhoto(criminalCode),
                        code = criminalCode
                    };
                    Console.WriteLine(criminalCode);
                    flowLayoutPanelCriminals.Controls.Add(criminals[criminal]);
                }
                criminal++;
                criminalCode++;
            } while (criminal < user.getNumberOfRows());
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            flowLayoutPanelCriminals.Controls.Clear();
            displayCriminals();
        }

    }
}

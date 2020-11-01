using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interpol
{
    public partial class Criminal : UserControl
    {

        public Criminal()
        {
            InitializeComponent();
        }

        private int _code = 0;
        private string _name = "";
        private string _surname= "";
        private string _nickname = "";
        private string _date = "";
        private string _residence = "";
        private string _specialization = "";
        private Image _image;

        public int code
        {
            get { return _code; }
            set { _code = value; }
        }

        public Image image
        {
            get { return _image; }
            set { _image = value;  pictureBoxCriminal.Image = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value;labelName.Text = value; }
        }

        public string surname
        {
            get { return _surname; }
            set { _surname = value; labelSurname.Text = value; }
        }

        public string nickname
        {
            get { return _nickname; }
            set { _nickname = value; labelNickname.Text = value; }
        }

        public string specialization
        {
            get { return _specialization; }
            set { _specialization = value; labelSpecialization.Text = value; }
        }

        public string date
        {
            get { return _date; }
            set { _date = value; labelBirthDate.Text = value; }
        }

        public string residence
        {
            get { return _residence; }
            set { _residence = value; labelLastResidence.Text = value; }
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {

            CriminalDetails cd = new CriminalDetails(code);
            cd.Show();
        }

    }
}

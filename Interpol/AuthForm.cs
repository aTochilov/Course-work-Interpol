﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Scrypt;

namespace Interpol
{
    public partial class AuthForm : Form
    {
        private string path = @".\users.dat";
        public AuthForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string hashedPassword = findHashed(login);
            string password = textBoxPassword.Text;
            ScryptEncoder encoder = new ScryptEncoder();
            if (password != "")
                if (hashedPassword != "0" && encoder.Compare(password, hashedPassword))
                {
                    switch(findLevel(login))
                    {
                        case "1":
                            GuestForm guestform = new GuestForm();
                            this.Hide();
                            break;
                        case "2":
                            AdminForm adminform = new AdminForm();
                            this.Hide();
                            break;
                    }
                }
                else MessageBox.Show("Wrong login or password.");
            else MessageBox.Show("Enter password.");
            textBoxLogin.ResetText();
            textBoxPassword.ResetText();
        }

        private string findHashed(string login)
        {
            string[] lines;
            if (!File.Exists(path))
            {
                 MessageBox.Show("File not found.");
            }
            else
            {
                lines = File.ReadAllLines(path);
                foreach(string line in lines)
                {
                    if ((line.Split(':')[0]) == login)
                    {
                        var hashedPassword = line.Split(':');
                        return hashedPassword[1];
                    }
                }
            }
            return "0";
        }

        private string findLevel(string login)
        {
            string[] lines;
            if (!File.Exists(path))
            {
                MessageBox.Show("File not found.");
            }
            else
            {
                lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    
                    if ((line.Split(':')[0]) == login)
                    {
                        var level = line.Split(':');
                        return level[2];
                    }
                }
            }
            return "0";
        }

        private void AuthForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

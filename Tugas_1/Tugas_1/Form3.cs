using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_1
{
    public partial class Form3 : Form
    {

        BindingList<Account> acc = new BindingList<Account>();



        public Form3()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 register = new Form1(this);
            register.Show();
            this.Hide();
        }

        private void signinButton_Click(object sender, EventArgs e)
        {
            string inputEmail = emailTbox.Text;
            string inputPassword = passwordTbox.Text;


            //call acc
            acc.Clear();
            if (File.Exists("account.txt"))
            {
                using (StreamReader reader = new StreamReader("account.txt"))
                {
                    string email;
                    string username;
                    string fullname;
                    string password;
                    while ((email = reader.ReadLine()) != null)
                    {
                        username = reader.ReadLine();
                        fullname = reader.ReadLine();
                        password = reader.ReadLine();

                        Account temp = new Account(email, username, fullname, password);
                        acc.Add(temp);

                    }

                }

            }


            //cek acc
            for (int i = 0; i < acc.Count; i++)
            {
              if(acc[i].email == inputEmail && acc[i].password == inputPassword)
                {
                    Form2 dashboard = new Form2(this, acc[i]);
                    dashboard.Show();
                    this.Hide();
                    return;
                }
              if(acc[i].email == inputEmail && acc[i].password != inputPassword)
                {
                    warningLabel.Text = "Wrong password!";
                    return;
                }
            }
            
            warningLabel.Text = "Account not found!";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

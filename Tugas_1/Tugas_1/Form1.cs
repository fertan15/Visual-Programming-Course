using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_1
{
    public partial class Form1 : Form
    {

        bool emailAdded = false;
        bool usernameAdded = false;
        bool fullnameAdded = false;
        bool passwordAdded = false;
        bool confirmPasswordAdded = false;


        Form3 master;

        public Form1(Form3 master)
        {
            InitializeComponent();
            this.master = master;
        }



        private void emailTbox_TextChanged(object sender, EventArgs e)
        {
            //email
            if (emailAdded == true && progressBar1.Value >= 20 && !Regex.IsMatch(emailTbox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                progressBar1.Value -= 20;
                emailAdded = false;

            }
            else if (emailAdded == false && progressBar1.Value <= 100 && Regex.IsMatch(emailTbox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                progressBar1.Value += 20;
                emailAdded = true;

            }

        }

        private void usernameTbox_TextChanged(object sender, EventArgs e)
        {
            //username
            if (usernameTbox.Text.Length == 0 && usernameAdded == true && progressBar1.Value >= 20)
            {
                progressBar1.Value -= 20;
                usernameAdded = false;

            }
            else if (usernameTbox.Text.Length > 0 && usernameAdded == false && progressBar1.Value <= 100)
            {
                progressBar1.Value += 20;
                usernameAdded = true;

            }

        }

        private void fullnameTbox_TextChanged(object sender, EventArgs e)
        {
            //fullname
            if (fullnameTbox.Text.Length == 0 && fullnameAdded == true && progressBar1.Value >= 20)
            {
                progressBar1.Value -= 20;
                fullnameAdded = false;

            }
            else if (fullnameTbox.Text.Length > 0 && fullnameAdded == false && progressBar1.Value <= 100)
            {
                progressBar1.Value += 20;
                fullnameAdded = true;

            }
        }

        private void passwordTbox_TextChanged(object sender, EventArgs e)
        {
            //password
            if (passwordTbox.Text.Length == 0 && passwordAdded == true && progressBar1.Value >= 20)
            {
                progressBar1.Value -= 20;
                passwordAdded = false;


            }
            else if (passwordTbox.Text.Length > 0 && passwordAdded == false && progressBar1.Value <= 100)
            {
                progressBar1.Value += 20;
                passwordAdded = true;

            }
        }

        private void confirmpasswordTbox_TextChanged(object sender, EventArgs e)
        {
            //confirm password
            if (confirmpasswordTbox.Text != passwordTbox.Text && confirmPasswordAdded == true)
            {
                progressBar1.Value -= 20;
                confirmPasswordAdded = false;

            }
            else if (confirmpasswordTbox.Text == passwordTbox.Text && confirmPasswordAdded == false)
            {
                progressBar1.Value += 20;
                confirmPasswordAdded = true;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            master.Show();
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            if (!emailAdded)
            {
                if (emailTbox.Text == "")
                {
                    errorProvider1.SetError(emailTbox, "Email cannot be empty.");
                }
                else
                {
                    errorProvider1.SetError(emailTbox, "Please enter a valid email address.");
                }
            }

            if (!usernameAdded)
            {
                errorProvider1.SetError(usernameTbox, "Username cannot be empty.");
            }

            if (!fullnameAdded)
            {
                errorProvider1.SetError(fullnameTbox, "Full name cannot be empty.");
            }

            if (!passwordAdded)
            {
                errorProvider1.SetError(passwordTbox, "Password cannot be empty.");
            }

            if (!confirmPasswordAdded)
            {
                if (confirmpasswordTbox.Text == "")
                {
                    errorProvider1.SetError(confirmpasswordTbox, "Please confirm your password.");
                }
                else
                {
                    errorProvider1.SetError(confirmpasswordTbox, "Passwords do not match.");
                }
            }

            if (emailAdded && usernameAdded && fullnameAdded && passwordAdded && confirmPasswordAdded)
            {
                Account newAccount = new Account(emailTbox.Text, usernameTbox.Text, fullnameTbox.Text, passwordTbox.Text);
                using (StreamWriter writer = new StreamWriter("account.txt", true))
                {
                    writer.WriteLine(newAccount.email);
                    writer.WriteLine(newAccount.username);
                    writer.WriteLine(newAccount.fullName);
                    writer.WriteLine(newAccount.password);
                }

                MessageBox.Show("Account created successfully!\n\n" +
                    "Email: " + newAccount.email + "\n" +
                    "Username: " + newAccount.username + "\n" +
                    "Full Name: " + newAccount.fullName);


                Form2 masuk = new Form2(master,newAccount);
                masuk.Show();
                this.Close();
            }
        }
    }

}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void emailTbox_TextChanged(object sender, EventArgs e)
        {
            //email
            if (emailTbox.Text.Length == 0 && emailAdded == true && progressBar1.Value >= 20) { 
                progressBar1.Value -= 20;
                emailAdded = false;

            }else if (emailTbox.Text.Length > 0 && emailAdded == false && progressBar1.Value <= 100) {
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
            //username
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
            //username
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
    }
}

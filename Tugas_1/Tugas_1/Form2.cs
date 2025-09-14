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
    public partial class Form2 : Form
    {

        Account user;
        Form3 master;
        public Form2(Form3 master,Account user)
        {
            InitializeComponent();
            this.user = user;
            greeting.Text = "Welcome, " + user.fullName + "!";
            this.master = master;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

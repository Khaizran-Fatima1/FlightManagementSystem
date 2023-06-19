using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UidTb.Text = "";
            PassTb.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Enter The UserId & Password");
            }
            else if (UidTb.Text == "Admin" && PassTb.Text == "123")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else { MessageBox.Show("Wrong UserName Or Password"); }
                   
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

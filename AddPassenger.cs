using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Airline
{
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-R8577T1\\SQLEXPRESS;Initial Catalog=\"SAHARA AIRWAYS\";Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddPassenger_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PassId.Text == "" || PassAd.Text == "" || PassName.Text == "" || PassportTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string PassengerId = PassId.Text;
                    string PassengerName = PassName.Text;
                    string PassportNum = PassportTb.Text;
                    string PassAddress = PassAd.Text;
                    string PassPhone = PhoneTb.Text;
                    string PassengerNationality = NationalityCb.SelectedItem.ToString();
                    string PassengerGender = GenderCb.SelectedItem.ToString();
                    string query = "INSERT INTO PassengerTbl VALUES('" + PassengerId + "','" + PassengerName + "', '" + PassportNum + "', '" + PassAddress + "', '" + PassengerNationality + "', '" + PassengerGender + "', '" + PassPhone + "');";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Recorded Successfully");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewPassenger viewpass = new ViewPassenger();
            viewpass.Show();
            this.Hide();
        }

        private void NationalityCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PassId.Text = "";
            PassName.Text = "";
            PassportTb.Text = "";
            PassAd.Text = "";
            PhoneTb.Text = "";
            NationalityCb.SelectedItem = "";
            GenderCb.SelectedItem = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home(); 
            home.Show();
            this.Hide();
        }

        private void GenderCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

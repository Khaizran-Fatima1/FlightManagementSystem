using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using System.Security.Cryptography;

namespace Airline
{
    public partial class FlightTbl : Form
    {
        public FlightTbl()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-R8577T1\\SQLEXPRESS;Initial Catalog=\"SAHARA AIRWAYS\";Integrated Security=True");

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || Fsrc.Text == "" || Fdest.Text == "" || Fdate.Text == "" || SeatNum.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO FlightTbl VALUES('" + FcodeTb.Text + "' , '" + Fsrc.SelectedItem.ToString() + "' ,'" + Fdest.SelectedItem.ToString() + "' ,' " + Fdate.Value.Date.ToString() + "', '" + SeatNum.Text +  "');";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Recorded Successfully");

                    Con.Close();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void SeatNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            SeatNum.Text = "";
        }

        private void FlightTbl_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_Flights Viewflt = new View_Flights();
            Viewflt.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}

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
using System.Text.RegularExpressions;

namespace Airline
{
    public partial class View_Flights : Form
    {
        public View_Flights()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-R8577T1\\SQLEXPRESS;Initial Catalog=\"SAHARA AIRWAYS\";Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM FlightTbl;";
        SqlDataAdapter sda = new SqlDataAdapter(query, Con);
        SqlCommandBuilder builder = new SqlCommandBuilder(sda);
        var ds = new DataSet();
        sda.Fill(ds);
           FlightDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
    private void View_Flights_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "")
            {
                MessageBox.Show("Enter The Flight to Delete");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from FlightTbl where Fcode='" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Deleted Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FlightTbl Addf1 = new FlightTbl();
            Addf1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            SeatNum. Text = "";
        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FcodeTb.Text = FlightDGV.SelectedRows[0].Cells[0].Value.ToString();
            SrcCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[1].Value.ToString();
            DestCb.SelectedItem = FlightDGV.SelectedRows[0].Cells[2].Value.ToString();
           SeatNum.Text = FlightDGV.SelectedRows[0].Cells[4].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "" || SeatNum.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE FlightTbl set Fsrc='" + SrcCb.SelectedItem.ToString() + "',Fdest='" + DestCb.SelectedItem.ToString() + "', FDate='" + FDate.Value.ToString() + "',SeatNum='" + SeatNum.Text + "' where Fcode= '" + FcodeTb.Text + "';";
                    SqlCommand Cmd = new SqlCommand(query, Con);
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Updated Successfully");

                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }
    }
}

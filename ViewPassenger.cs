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
    public partial class ViewPassenger : Form
    {
        public ViewPassenger()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-R8577T1\\SQLEXPRESS;Initial Catalog=\"SAHARA AIRWAYS\";Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM PassengerTbl;";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder= new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
           PassengerDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPassenger addpas = new AddPassenger();
            addpas.Show();
            this.Hide();
        }

        private void ViewPassenger_Load(object sender, EventArgs e)
        {
            populate(); 
        }

        private void PassengerDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PIdTb.Text = PassengerDGV.SelectedRows[0].Cells[0].Value.ToString();
            PName.Text = PassengerDGV.SelectedRows[0].Cells[1].Value.ToString();
            PPassport.Text = PassengerDGV.SelectedRows[0].Cells[2].Value.ToString();
            PAd.Text = PassengerDGV.SelectedRows[0].Cells[3].Value.ToString();
            natCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[4].Value.ToString();
            gendCb.SelectedItem = PassengerDGV.SelectedRows[0].Cells[5].Value.ToString();
            Pphone.Text = PassengerDGV.SelectedRows[0].Cells[6].Value.ToString() ;

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(PIdTb.Text== "") {
                MessageBox.Show("Enter Passenger to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "DELETE FROM PassengerTbl where PassId=" + PIdTb.Text + ";";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger deleted successfully");
                    Con.Close(); 
                    populate();

                }catch(Exception ex)
                {

                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PIdTb.Text = "";
            PName.Text = "";
            PPassport.Text = "";
            PAd.Text = "";
            Pphone.Text = "";
            natCb.SelectedItem = "";
            gendCb.SelectedItem = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(PIdTb.Text == "" || PName.Text == "" || PPassport.Text == ""|| PAd.Text == "" || Pphone.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "UPDATE PassengerTbl set PassName='" + PName.Text +"',Passport='"+PPassport.Text+"',PassAd='"+ PAd.Text+ "',Passnat='"+natCb.SelectedItem.ToString()+"',PassGend='"+gendCb.SelectedItem.ToString()+"',PassPhone='"+Pphone.Text+"' where PassId="+PIdTb.Text+";";
                  SqlCommand Cmd = new SqlCommand(query,Con);
                    Cmd.ExecuteNonQuery();
                    MessageBox.Show("Passenger Updated Successfully");

                    Con.Close() ;
                    populate();

                }catch(Exception ex )
                {
                    MessageBox.Show("Missing Information");
                }
            }
        }
    }
}

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
namespace Airline
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-R8577T1\\SQLEXPRESS;Initial Catalog=\"SAHARA AIRWAYS\";Integrated Security=True");

        private void populate()
        {
            Con.Open();
            string query = "SELECT * FROM TicketTbl;";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TicketDGV.DataSource = ds.Tables[0];
            Con.Close();
        }


        private void fillPassenger()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PassId from PassengerTbl ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PassId", typeof(int));
            dt.Load(rdr);
            PIdCb.ValueMember = "PassId";
            PIdCb.DataSource = dt;

            Con.Close();
        }
        private void fillFlightCode()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Fcode from FlightTbl ", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Fcode", typeof(string));
            dt.Load(rdr);
            FCodeCb.ValueMember = "Fcode";
           FCodeCb.DataSource = dt;

            Con.Close();
        }
        string pname, ppass, padd, pnat, pgend;
            int page;

        private void PNatTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tid.Text == "" || PNameTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "INSERT INTO TicketTbl VALUES('" + Tid.Text + "','" + FCodeCb.SelectedValue.ToString() + "', '" + PIdCb.SelectedValue.ToString() + "', '" + PNameTb.Text + "', '" + PPassTb.Text + "', '" + PNatTb.Text + "','"+PAgeTb.Text+"', '" + PAmtTb.Text + "');";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ticket Booked Successfully");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PNameTb.Text = "";
            PPassTb.Text = "";
            PNatTb.Text = "";
            PAgeTb.Text = "";
            PAmtTb.Text = "";
            Tid.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void TicketDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fetchPassenger()
        {
            Con.Open();
            string query = "Select * from PassengerTbl where PassId= " + PIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows ){
                pname = dr["PassName"].ToString();
                ppass= dr["Passport"].ToString();
                pnat = dr["PassNat"].ToString();
                PNameTb.Text = pname;
                PPassTb.Text = ppass;
                PNatTb.Text = pnat;

            }
            Con.Close();
        }
        private void Ticket_Load(object sender, EventArgs e)
        {
            fillPassenger();
            fillFlightCode();
            populate();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchPassenger();
        }
    }
}

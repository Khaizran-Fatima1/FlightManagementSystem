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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightTbl flight = new FlightTbl();
            flight.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPassenger pass = new AddPassenger();
            pass.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ticket tick = new Ticket();
            tick.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CancellationTbl Can = new CancellationTbl();
            Can.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

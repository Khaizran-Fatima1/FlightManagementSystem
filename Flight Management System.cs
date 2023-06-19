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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Myprogress.Increment(3);
            if (Myprogress.Value >= Myprogress.Maximum)
            {
                timer1.Stop();
                this.Hide();
                Login log = new Login();
                log.Show();


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
           }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

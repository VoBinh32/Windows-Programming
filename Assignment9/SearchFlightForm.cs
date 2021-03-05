using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment9
{
    public partial class SearchFlightForm : Form
    {
        public SearchFlightForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showFlightInfoBox.Text = Flight.flightWithCustomerInformation(flightIDBox.Text);
            flightIDBox.Text = "";
        }

        
        private void smallToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showFlightInfoBox.Font = new Font("Arial", 6, FontStyle.Regular);
        }

        private void normalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showFlightInfoBox.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void bigToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showFlightInfoBox.Font = new Font("Arial", 20, FontStyle.Regular);
        }

        private void redToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showFlightInfoBox.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showFlightInfoBox.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showFlightInfoBox.BackColor = Color.Blue;
        }
    }
}

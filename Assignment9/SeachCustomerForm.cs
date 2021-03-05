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
    public partial class SeachCustomerForm : Form
    {
        public SeachCustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showCustomerBox.Text = Customer.customerInformation(int.Parse(idBox.Text));
            idBox.Text = "";
        }
       

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCustomerBox.Font = new Font("Arial", 6, FontStyle.Regular);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCustomerBox.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCustomerBox.Font = new Font("Arial", 20, FontStyle.Regular);
        }

        private void redToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showCustomerBox.BackColor = Color.Red;
        }

        private void pinkToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            showCustomerBox.BackColor = Color.Pink;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showCustomerBox.BackColor = Color.Yellow;
        }
    }
}

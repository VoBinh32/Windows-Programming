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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(customerIDBox.Text);
            string name = customerNameBox.Text;
            string flightID = flightIDBox.Text;

            Customer customer = new Customer(id, name, flightID);

            List<Customer> customers = FileHandler.ReadXML<Customer>(FileHandler.CustomerFilePath);

            customers.Add(customer);

            customerIDBox.Text = "";
            customerNameBox.Text = "";
            flightIDBox.Text = "";

            FileHandler.WriteXML<Customer>(customers, FileHandler.CustomerFilePath);

        }
    }
}

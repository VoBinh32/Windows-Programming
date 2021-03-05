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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        SearchFlightForm searchFlightForm;
        AddFlightForm addFlightForm;
        SeachCustomerForm searchCustomerForm;
        AddCustomerForm addCustomerForm;

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchFlightForm == null || searchFlightForm.IsDisposed)
            {
                searchFlightForm = new SearchFlightForm();
            }
            searchFlightForm.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addFlightForm == null || addFlightForm.IsDisposed)
            {
                addFlightForm = new AddFlightForm();
            }
            addFlightForm.Show();
        }

        private void searchCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (searchCustomerForm == null || searchCustomerForm.IsDisposed)
            {
                searchCustomerForm = new SeachCustomerForm();
            }
            searchCustomerForm.Show();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (addCustomerForm == null || addCustomerForm.IsDisposed)
            {
                addCustomerForm = new AddCustomerForm();
            }
            addCustomerForm.Show();
        }
    }
}

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
    public partial class AddFlightForm : Form
    {
        public AddFlightForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = flightIDBox.Text;
            string origin = originBox.Text;
            string destination = destinationBox.Text;
            string date = dateBox.Text;
            string company = airlineBox.Text;

            Flight flight = new Flight(id, origin, destination, date, company);

            List<Flight> flights = FileHandler.ReadXML<Flight>(FileHandler.FlightCustomerFilePath);

            flights.Add(flight);

            flightIDBox.Text = "";
            originBox.Text = "";
            destinationBox.Text = "";
            dateBox.Text = "";
            airlineBox.Text = "";

            FileHandler.WriteXML<Flight>(flights, FileHandler.FlightCustomerFilePath);

        }
    }
}

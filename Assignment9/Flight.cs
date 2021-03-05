using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment9
{
    [XmlRoot("Flight")]
    public class Flight
    {
        private string id;
        private string origin;
        private string destination;
        private string date;
        private string airlineCompany;
       
        public Flight()
        {

        }

        public Flight(string id, string origin, string destination, string date, string airlineCompany)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
            this.airlineCompany = airlineCompany;

        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("ID: " + id + ", origin: " + origin + ", destination: " + destination + ", date: " + date + ", airline company: " + airlineCompany + Environment.NewLine);
       
            return result.ToString();
        }

        [XmlElement("AirlineCompany")]
        public string AirlineCompany
        {
            get
            {
                return airlineCompany;
            }
            set
            {
                airlineCompany = value;
            }
        }
        [XmlElement("FlightID")]
        public string Id

        {

            get

            {

                return id;

            }
            set
            {
                id = value;
            }

        }
        [XmlElement("Origin")]
        public string Origin

        {

            get

            {

                return origin;

            }
            set
            {
                origin = value;
            }

        }
        [XmlElement("Destination")]
        public string Destination

        {

            get

            {

                return destination;

            }
            set
            {
                destination = value;
            }

        }
        [XmlElement("Date")]
        public string Date

        {

            get

            {

                return date;

            }
            set
            {
                date = value;
            }

        }
        public string FindFlight(string id)
        {
            StringBuilder result = new StringBuilder();
            if (id.Equals(this.Id))
            {
                return this.ToString();
            }
            return "";
        }
        public static string flightWithCustomerInformation(string flightID)
        {
            List<Flight> flights = FileHandler.ReadXML<Flight>(FileHandler.FlightCustomerFilePath);
            StringBuilder result = new StringBuilder();
            foreach(Flight f in flights)
            {
                result.Append(f.FindFlight(flightID));
            }
            result.Append(Customer.findCustomer(flightID));
            return result.ToString();
        }

        public static string flightInformation(string flightID)
        {
            List<Flight> flights = FileHandler.ReadXML<Flight>(FileHandler.FlightCustomerFilePath);
            StringBuilder result = new StringBuilder();
            foreach (Flight f in flights)
            {
                result.Append(f.FindFlight(flightID));
            }
          
            return result.ToString();
        }
    }
}



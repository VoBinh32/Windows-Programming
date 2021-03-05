using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment9
{
    [XmlRoot("Customer")]
    public class Customer
    {
        int id;
        string name;
        string flightId;

        public Customer()
        {

        }

        public Customer(int id, string name, string flightId)
        {
            this.id = id;
            this.name = name;
            this.flightId = flightId;
        }

        [XmlElement("ID")]
        public int Id

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
        [XmlElement("Name")]
        public string Name

        {

            get

            {

                return name;

            }
            set
            {
                name = value;
            }

        }
        [XmlElement("FlightID")]
        public string FlightId

        {

            get

            {

                return flightId;

            }
            set
            {
                flightId = value;
            }

        }
        public override string ToString()
        {
            return "Customer id: " + id + ", Name: " + name + ", FlightID: " + flightId;
        }

        public static string customerInformation(int customerID)
        {
            List<Customer> customers = FileHandler.ReadXML<Customer>(FileHandler.CustomerFilePath);
            StringBuilder result = new StringBuilder();
            foreach (Customer customer in customers)
            {
                if (customer.Id == customerID)
                {
                    result.AppendLine(customer.ToString());
                    result.AppendLine(Flight.flightInformation(customer.flightId));
                }
            }

            return result.ToString();
        }

        public static string findCustomer(string flightID)
        {
            List<Customer> customers = FileHandler.ReadXML<Customer>(FileHandler.CustomerFilePath);
            StringBuilder result = new StringBuilder();
            foreach (Customer customer in customers)
            {
                if (customer.FlightId.Equals(flightID))
                {
                    result.AppendLine(customer.ToString());
                    
                }
            }

            return result.ToString();
        }
    }
}

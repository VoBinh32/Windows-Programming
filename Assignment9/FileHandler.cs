using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Assignment9
{
    class FileHandler
    {
        private const string customerFilePath = @"D:\customer.txt";
        private const string flightFilePath = @"D:\flight.txt";

        public static string CustomerFilePath => customerFilePath;

        public static string FlightCustomerFilePath => flightFilePath;

        
       
        public static void WriteXML<T>(List<T> list, string fileName)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (TextWriter textWriter = new StreamWriter(fileName))
            {
                serializer.Serialize(textWriter, list);
                textWriter.Close();
            }

            
        }

        
        public static List<T> ReadXML<T>(string fileName)
        {
            List<T> result;
            if (!System.IO.File.Exists(fileName))
            {
                return new List<T>();
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
            using (FileStream myFileStream = new FileStream(fileName, FileMode.Open))
            {
                result = (List<T>)xmlSerializer.Deserialize(myFileStream);
            }
            return result;
        }
    }
}
   
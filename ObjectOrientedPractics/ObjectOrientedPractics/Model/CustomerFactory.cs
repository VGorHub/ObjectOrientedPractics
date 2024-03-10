using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Model
{
    class CustomerFactory
    {
        private static int _generateCouter;
        public static Customer GenerateCustomer(List<Customer> customersList)
        {
            string _customerString;
            string _fullname;
            Address _address = new Address();

            Random random = new Random();

            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectPath, "Data", "Customers.txt");
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (_generateCouter < lines.Length)
            {
                do
                {
                    int randomIndex = random.Next(0, lines.Length);
                    _customerString = lines[randomIndex];

                    string[] parts = _customerString.Split('\t');
                    _fullname = parts[0] + " " + parts[1] + " " + parts[2];
                    string[] partsAddress = parts[3].Split(',');
                    _address.Index = "100500";
                    _address.Country = partsAddress[0];
                    _address.City = partsAddress[1];
                    _address.Street = partsAddress[2];
                    string[] partsBuilding = partsAddress[3].Split(' ');
                    _address.Building = partsBuilding[0]+ partsBuilding[1]+ partsBuilding[2];
                    _address.Apartment = partsBuilding[3];

                } while (customersList.Any(item => item.Fullname == _fullname));

                Customer newCustomer = new Customer(_fullname, _address);

                _generateCouter++;
                return newCustomer;
            }
            else
            {
                throw new Exception("Уникальные данные закончились");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;


namespace ObjectOrientedPractics.Model
{
    class ItemFactory
    {
        private static int _generateCouter;
        public static Item GenerateItem(List<Item> itemsList)
        {
            string _itemString;
            string _name;
            string _info;
            float floatValue;

            Random random = new Random();

            string projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath = Path.Combine(projectPath, "Data", "Items.txt");
            string[] lines = System.IO.File.ReadAllLines(filePath);
            if (_generateCouter < lines.Length)
            {
                do
                {
                    int randomIndex = random.Next(0, lines.Length);
                    _itemString = lines[randomIndex];

                    string[] parts = _itemString.Split('\t');
                    floatValue = float.Parse(parts[0]);
                    _name = parts[1];
                    _info = parts[2];

                } while (itemsList.Any(item => item.Name == _name));

                Item newItem = new Item(_name, _info, floatValue);
                _generateCouter++;
                return newItem;
            }
            else
            {
                throw new Exception("Уникальные данные закончились");
            }
            
        }
    }
}

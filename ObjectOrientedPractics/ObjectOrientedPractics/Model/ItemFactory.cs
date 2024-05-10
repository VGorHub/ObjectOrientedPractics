using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using ObjectOrientedPractics.Model.Enums;

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
            Category _itemCategory = Category.None;

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

                    _itemCategory = ParseCategory(parts[3]);

                } while (itemsList.Any(item => item.Name == _name));

                Item newItem = new Item(_name, _info, floatValue, _itemCategory);
                _generateCouter++;
                return newItem;
            }
            else
            {
                throw new Exception("Уникальные данные закончились");
            }
            
        }
        public static Category ParseCategory(string value)
        {
            if (Enum.TryParse(value, out Category category))
            {
                return category;
            }
            else
            {                
                return Category.None;
            }
        }
    }
}

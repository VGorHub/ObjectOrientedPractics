using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;
using static ObjectOrientedPractics.Model.Category;

namespace ObjectOrientedPractics.Model
{
    public class Item
    {
        private int _id;
        private string _name;
        private string _info;
        private float _cost;
        private static int _counter = 0;
        private Category _itemCategory;

        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _counter += 1;
                _id = value;                
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {                
                ValueValidator.AssertStringOnLength(value,200,nameof(Name));
                _name = value;
            }
        }
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {               
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        
        public float Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                if (value < 0 || value > 100000)
                {
                    throw new Exception("Цена товара должена быть от 0 до 100 000");
                }
                _cost = value;
            }
        }
        public Category ItemCategory
        {
            get
            {
                return _itemCategory;
            }
            set
            {
                _itemCategory = value;
            }
        }
        public Item(string name,string info,float cost,Category itemCategory){            
            Name = name;
            Info = info;
            Cost = cost;
            Id = _counter;
            ItemCategory = itemCategory;            
        }        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    class Store
    {
        List<Item> _items;
        List<Customers> _customers;

        public List<Item> Items
        {
            get 
            { 
               return _items; 
            }
            set 
            { 
                _items = value; 
            }
        }

        public List<Customers> Customers
        {
            get 
            { 
                return _customers; 
            }
            set 
            { 
                _customers = value; 
            }
        }

        public Store()
        {
            _items = new List<Item>();
            _customers = new List<Customers>();
        }
    }
}

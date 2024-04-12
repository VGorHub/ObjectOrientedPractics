using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class Cart
    {
        private List<Item> _items = new List<Item>();
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


        public double Amount
        {
            get
            {
                if (_items.Count == 0)
                {
                    return 0;
                }
                double _amount = 0;
                for(int i=0; i < _items.Count; i++)
                {
                    _amount += _items[i].Cost;
                }
                return _amount;
            }
        }


    }
}

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
        // Реализация ICloneable вместо конструктора копирования
        public object Clone()
        {
            return new Cart();
        }
        public bool Equals(Cart other)
        {
            if (other == null)
                return false;

            // Сравниваем количество товаров в корзине
            if (this._items.Count != other._items.Count)
                return false;

            // Сравниваем каждый товар в корзине
            for (int i = 0; i < _items.Count; i++)
            {
                if (!this._items[i].Equals(other._items[i]))
                    return false;
            }

            return true;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals(obj as Cart);
        }

    }
}

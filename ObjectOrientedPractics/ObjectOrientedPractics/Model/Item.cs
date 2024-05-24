using System;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;

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
        /// <summary>
        /// Событие при обновлении <see cref="Cost"/> объекта <see cref="Item"/>.
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Событие при обновлении <see cref="Name"/> объекта <see cref="Item"/>.
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;

        /// <summary>
        /// Событие при обновлении <see cref="Info"/> объекта <see cref="Item"/>.
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;
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
                NameChanged?.Invoke(this, EventArgs.Empty);
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
                InfoChanged?.Invoke(this, EventArgs.Empty);
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
                CostChanged?.Invoke(this, EventArgs.Empty);
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
        // Реализация ICloneable вместо конструктора копирования
        public object Clone()
        {
            return new Item(this.Name, this.Info,this.Cost,this.ItemCategory);
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != this.GetType()) return false;
            if (object.ReferenceEquals(this, obj)) return true;

            Item other = (Item)obj;
            return this.Id == other.Id;
        }
        public int CompareTo(Item other)
        {
            if (other == null)
                return 1;

            return this.Cost.CompareTo(other.Cost);
        }

    }
}

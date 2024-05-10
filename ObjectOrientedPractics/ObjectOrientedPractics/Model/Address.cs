using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        private string _index; // - почтовый индекс, целое шестизначное число.
        private string _country; // - страна/регион, строка, не более 50 символов.
        private string _city; // - город (населенный пункт), строка, не более 50 символов.
        private string _street; // - улица, строка, не более 100 символов.
        private string _building; // – номер дома, строка, не более 10 символов.
        private string _apartment;// – номер квартиры/помещения, не более 10 символов.

        public string Index
        {
            get
            {
                return _index;
            }
            set
            {
                if (value.Length != 6)
                {
                    throw new Exception("Index Должен быть длиною в 6 символов");
                }
                try
                {
                    int.Parse(value);
                    _index = value;
                }
                catch
                {
                    throw new Exception("Не удалось преобразовать Index В Int");
                }
            }
        }
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }
        public Address()
        {
            Index = "000000";
            Country = "-";
            City = "-";
            Street = "-";
            Building = "-";
            Apartment = "-";
        }
        public Address(string index,string country, string city, string street, string building,string apartament)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartament;
        }
        // Реализация ICloneable вместо конструктора копирования
        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment);
        }

        public bool Equals(Address other)
        {
            if (other == null)
                return false;

            return this.Index == other.Index &&
                   this.Country == other.Country &&
                   this.City == other.City &&
                   this.Street == other.Street &&
                   this.Building == other.Building &&
                   this.Apartment == other.Apartment;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            return Equals(obj as Address);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    class Customer
    {
        private int _id;
        private string _fullname;
        private string _address;
        private static int _counter = 0;

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _counter += 1;
                _id = value;
            }
        }
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {             
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;                
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {                
                ValueValidator.AssertStringOnLength(value, 500, nameof(Address));
                _address = value;               
            }
        }
        public Customer(string fullname,string address)
        {
            Id = _counter;
            Fullname = fullname;
            Address = address;
        }        
    }
}

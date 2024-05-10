
using System.Collections.Generic;

using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.Model
{
    public class Customers
    {
        private int _id;
        private string _fullname;
        private Address _address;
        private static int _counter = 0;
        private Cart _cart;
        private List<Order> _orders;
        private List<IDiscount> _discounts ;        


        public List<IDiscount> Discounts
        {
            get { return _discounts; }

            set { _discounts = value; }
        }
        public bool IsPriority { get; set; }

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
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {                
                
                _address = value;               
            }
        }
        public Cart Cart
        {
            get 
            {
                return _cart;
            } 
            set 
            { 
                _cart = value;
            }
        }

        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }
        public Customers(string fullname,Address address)
        {
            Id = _counter;
            Fullname = fullname;
            Address = address;
            Cart = new Cart();
            Orders = new List<Order>();
            IsPriority = false;
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }        
    }
}

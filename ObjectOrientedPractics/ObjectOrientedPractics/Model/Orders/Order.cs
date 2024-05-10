using System;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    public class Order
    {
        private static int _counter = 0;
        private int _id;
        private readonly DateTime _creationDate;
        private Cart _cart;
        private Address _deliveryAddress;
        private double _totalPrice;
        OrderStatus _orderStatus = 0;
        private readonly string _fullname;
        private double _discountAmount;

        public double DiscountAmount
        {
            get
            {
                return _discountAmount;
            }
            set
            {
                _discountAmount = value;
            }
        }
        public double Total()
        {
            return _cart.Amount - DiscountAmount;
        }

        public OrderStatus OrderStatus
        {
            get { return _orderStatus; }
            set { _orderStatus = value; }
        }
        public double TotalPrice
        {
            get { return _totalPrice; }
        }
        public string Fullname
        {
            get { return _fullname; }
        }
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
        public DateTime CreationDate
        {
            get { return _creationDate; }

        }
        public Address DeliveryAddress 
        { 
            get 
            { 
                return _deliveryAddress; 
            } 
            set 
            { 
                _deliveryAddress = value;
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
                _totalPrice =value.Amount;
            }
        }
        
        public Order(DateTime creationDate, Address deliveryAddress, Cart cart, string fullname)
        {
            Id = _counter;
            _creationDate = creationDate;
            DeliveryAddress = deliveryAddress;
            Cart = cart;
            _fullname = fullname;
        }        
    }
}

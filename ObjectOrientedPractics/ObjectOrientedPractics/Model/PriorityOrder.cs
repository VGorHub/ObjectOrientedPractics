﻿using System;

namespace ObjectOrientedPractics.Model
{
    public class PriorityOrder : Order
    {
        public DateTime WishDate { get; set; }
        public WishTimeEnum WishTime { get; set; }

        public PriorityOrder(DateTime creationDate, Address deliveryAddress, Cart cart, string fullname, DateTime wishDate, WishTimeEnum wishTime)
            : base(creationDate, deliveryAddress, cart, fullname)
        {
            WishDate = wishDate;
            WishTime = wishTime;
        }
    }
}

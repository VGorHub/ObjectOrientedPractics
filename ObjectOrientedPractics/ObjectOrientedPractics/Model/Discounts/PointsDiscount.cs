using System;
using System.Collections.Generic;


namespace ObjectOrientedPractics.Model.Discounts
{
    internal class PointsDiscount : IDiscount
    {
        private int _pointsCount;
        public string Info
        {
            get
            {
                return $"Накопительная – {PointsCount} баллов";
            }
        }
         
        public int PointsCount
        {
            get
            {
                return _pointsCount;
            }
            
        }
        private int SetPointsCount
        {
            set
            {
                if(value < 0 )
                {
                    throw new Exception($"{value} < 0");
                }
                _pointsCount = value;
            }
        }
        public double Calculate(List<Item> items)
        {
            double totalCost = 0;
            foreach (var item in items)
            {
                totalCost += item.Cost;
            }
            double maxSale = totalCost*0.30;
            if (maxSale <= PointsCount)
            {
                return maxSale;
            }
            else
            {
                return PointsCount;
            }            
        }
        public double Apply(List<Item> items)
        {
            double sale = Calculate(items);
            double saleForItem= sale / items.Count;
            foreach (var item in items)
            {
                item.Cost = (float)(item.Cost - saleForItem);
            }
            SetPointsCount = PointsCount - (int)sale;
            return sale;
        }
        public void Update(List<Item> items)
        {
            foreach (var item in items)
            {
                SetPointsCount = PointsCount + (int)(item.Cost * 0.10);
            }
        }

        public PointsDiscount()
        {            
            SetPointsCount = 0;
        }
        public int CompareTo(PointsDiscount other)
        {
            if (other == null)
                return 1;

            return this.PointsCount.CompareTo(other.PointsCount);
        }

    }
}

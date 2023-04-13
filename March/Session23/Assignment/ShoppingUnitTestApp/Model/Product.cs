using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Model
{
    public class Product
    {
        private readonly int _id;
        private readonly string _name;
        private readonly double _price;
        private readonly double _discountPercentage;
       

        public double PriceAfterDiscount => CalculatePriceAfterDiscount();
        public Product(int id, string name, double price, double discountPercentage)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercentage = discountPercentage;
        }

        private double CalculatePriceAfterDiscount()
        {
            return _price * (1 - _discountPercentage / 100);
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }
        public double DiscountPercentage
        {
            get
            {
                return _discountPercentage;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }
        }
    }

}


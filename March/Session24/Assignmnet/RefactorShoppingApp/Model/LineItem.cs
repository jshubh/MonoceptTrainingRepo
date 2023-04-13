using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Model
{
    public class LineItem
    {
        private static int _idCounter = 0;
        private readonly int _id;
        private readonly Product _product;
        private int _quantity;

        public double TotalPrice => CalculateItemCost();
        
        public Product Product => _product;

        public LineItem(Product product, int quantity)
        {
            _id = ++_idCounter;
            _product = product;
            _quantity = quantity;
        }

        private double CalculateItemCost()
        {
            return _quantity * _product.PriceAfterDiscount;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }
    }
}
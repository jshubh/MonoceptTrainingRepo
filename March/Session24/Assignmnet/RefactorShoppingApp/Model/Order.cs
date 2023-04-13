using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Model
{

    public class Order
    {
        private static int _idCounter = 0;
        private readonly int _id;
        private readonly DateTime _createdDate;
        private readonly List<LineItem> _lineItems;

        public double CheckoutPrice => CalculateCheckoutPrice();
        public IReadOnlyList<LineItem> LineItems => _lineItems;

        public Order()
        {
            _id = ++_idCounter;
            _createdDate = DateTime.UtcNow;
            _lineItems = new List<LineItem>();
        }

        public void AddLineItem(LineItem lineItem)
        {
            LineItem existingLineItem = _lineItems.FirstOrDefault(li => li.Product.Id == lineItem.Product.Id);
            if (existingLineItem != null)
            {
                existingLineItem.Quantity += lineItem.Quantity;
               
            }
            else
            {
                _lineItems.Add(lineItem);
            }
        }

        private double CalculateCheckoutPrice()
        {
            double totalPrice = 0;
            foreach (var lineItem in _lineItems)
            {
                totalPrice += lineItem.TotalPrice;
            }
            return totalPrice;
        }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public DateTime CreatedDate
        {
            get
            {
                return _createdDate;
            }
        }

        public int LineItemCount
        {
            get
            {
                return _lineItems.Count;
            }
        }
    }
}
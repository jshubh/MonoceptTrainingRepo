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

        public int _count;
      
        public Order()
        {
            _id = ++_idCounter;
            _createdDate = DateTime.UtcNow;
            
            LineItems = new List<LineItem>();
        }
        public double CheckOutPrice
        {
            get
            {
                return CalculateCheckoutPrice();
            }
        }
        public List<LineItem> LineItems { get; set; }




        public void AddLineItem(LineItem lineItem)
        {
            LineItems.Add(lineItem);
        }

        private double CalculateCheckoutPrice()
        {
            double totalPrice = 0;
            foreach (var lineItem in LineItems)
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
        public DateTime CretatedDate
        {
            get
            {
                return _createdDate;
            }
        }
        public int Counts
        {
            get
            {
                return LineItems.Count;
            }
        }
    }
}

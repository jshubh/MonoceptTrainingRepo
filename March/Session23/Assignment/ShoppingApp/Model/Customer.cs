using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Model
{
     public  class Customer
    {
        private readonly int _id;
        private readonly string _name;
        private readonly List<Order> _orders;

        

        public List<Order> Orders => _orders;

        public Customer(int id, string name)
        {
            _id = id;
            _name = name;
            _orders = new List<Order>();
        }

        public Order AddOrder(Order order)
        {
          
            _orders.Add(order);
            return order;
        }

        public void RemoveOrder(Order order)
        {
            _orders.Remove(order);
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}

   
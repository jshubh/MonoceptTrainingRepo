using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    internal class Customer
    {
        private int _id;
        private string _name;
        private int _orderCount=1;
        private static int _nextId;
        static Customer()
        {
            _nextId = 1000;
        }


        public Customer(string name,int OrderCount)
        {
           
            _name = name;
            _orderCount = OrderCount;
            _nextId += 1;
            _id = _nextId;
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
        public  int OrderCount
        {
            get
            {
                return _orderCount;
            }
        }
       public   int Id
        {
            get
            {
                return _id;
            }
           
        }
    }
}

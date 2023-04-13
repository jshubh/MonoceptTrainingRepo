using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerHashSet.Model
{
    internal class Customer
    {
        private string _name;
        private int _id;
        public Customer(int id,string name)
        {
            _id = id;
            _name = name;
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
        public override int GetHashCode()
        {
            return _id;
        }
        public override bool Equals(object second)
        {
            Customer secondCustomer = (Customer) second;
            return this.Id == secondCustomer.Id;
        }
    }
}

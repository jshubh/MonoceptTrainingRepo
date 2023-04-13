using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStrategyDesignPattern.Model
{
    public class ExpressShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(double weight, string destination)
        {
           
            return weight * 1.5 + 20;
        }
    }

}

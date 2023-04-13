using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStrategyDesignPattern.Model
{
    internal class StandardShippingStrategy
    {
        public double CalculateShippingCost(double weight, string destination)
        {
          
            return weight * 0.5 + 10;
        }
    }
}

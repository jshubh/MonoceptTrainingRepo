using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStrategyDesignPattern.Model
{
    
        public class InternationalShippingStrategy : IShippingStrategy
        {
            public double CalculateShippingCost(double weight, string destination)
            {
               
                double ratePerKg = GetRatePerKg(destination);
                return weight * ratePerKg + 30;
            }
        private double GetRatePerKg(string destination)
        {
          
            return 2.0;
        }
    }
}

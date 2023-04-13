using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStrategyDesignPattern.Model
{
    public interface IShippingStrategy
    {
        double CalculateShippingCost(double weight, string destination);
    }
}

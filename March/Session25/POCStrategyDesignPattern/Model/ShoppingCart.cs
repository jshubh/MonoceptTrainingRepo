using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStrategyDesignPattern.Model
{
     class ShoppingCart
    {
      
            public double CalculateTotalCost(double cartTotal, double weight, string destination, string shippingMethod)
            {
                double shippingCost = 0;

                if (shippingMethod == "standard")
                {
                   
                    shippingCost = weight * 0.5 + 10;
                }
                else if (shippingMethod == "express")
                {
                   
                    shippingCost = weight * 1.5 + 20;
                }
                else if (shippingMethod == "international")
                {
                  
                    double ratePerKg = GetRatePerKg(destination);
                    shippingCost = weight * ratePerKg + 30;
                }

                return cartTotal + shippingCost;
            }

            private double GetRatePerKg(string destination)
            {
              
                return 2.0;
            }
        }

    }


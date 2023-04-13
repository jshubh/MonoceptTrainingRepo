using POCStrategyDesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCStrategyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStud1();
           
        }
        private static void CaseStud1()
        {
            ShoppingCart cart = new ShoppingCart();
            double total1 = cart.CalculateTotalCost(100, 2, "USA", "standard");
            double total2 = cart.CalculateTotalCost(100, 2, "USA", "express");
            double total3 = cart.CalculateTotalCost(100, 2, "Canada", "international");

            Console.WriteLine($"Total cost with standard shipping: {total1:C}");
            Console.WriteLine($"Total cost with express shipping: {total2:C}");
            Console.WriteLine($"Total cost with international shipping: {total3:C}");
        }
    }
}
  
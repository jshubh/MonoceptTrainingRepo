using StragtegyDesignPatternUsingDelegates.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StragtegyDesignPatternUsingDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
          ShoppingCart   cart = new ShoppingCart();

            // Add items to the cart
            cart.AddItem(new Item("Book", 10));
            cart.AddItem(new Item("DVD", 5));
            cart.AddItem(new Item("CD", 7));

            // Calculate the total price using different strategies
            Console.WriteLine("Using standard pricing strategy:");
            cart.CalculateTotalPrice(StandardPricingStrategy);
            Console.WriteLine();

            Console.WriteLine("Using discount pricing strategy:");
            cart.CalculateTotalPrice(DiscountPricingStrategy);
            Console.WriteLine();
        }

      
        static decimal StandardPricingStrategy(decimal price, int quantity)
        {
            return price * quantity;
        }

        static decimal DiscountPricingStrategy(decimal price, int quantity)
        {
            const decimal discountRate = 0.9m;
            return price * quantity * discountRate;
        }
    }
}
    
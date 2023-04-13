using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StragtegyDesignPatternUsingDelegates.Model
{
    public class ShoppingCart
    {
        private readonly List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void CalculateTotalPrice(Func<decimal, int, decimal> pricingStrategy)
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += pricingStrategy(item.Price, 1);
            }

            Console.WriteLine($"Total price: {total:C}");
        }
    }
}

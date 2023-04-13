using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StragtegyDesignPatternUsingDelegates.Model
{
   public class Item
    {
         public string Name { get; }
        public decimal Price { get; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}

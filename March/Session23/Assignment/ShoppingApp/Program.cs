using ShoppingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Product 1", 100, .3);
            Product product2 = new Product(2, "Product 2", 200, .6);
            


            Customer customer = new Customer(1, "Shubh Jain");
            Order order1 = new Order();
            order1.AddLineItem(new LineItem(product1, 1));
            order1.AddLineItem(new LineItem(product2, 1));


            customer.AddOrder(order1);
            Console.WriteLine("Customer: " + customer.Name);
            foreach (var order in customer.Orders)
            {
                Console.WriteLine("Order:");
                foreach (var lineItem in order.LineItems)
                {
                    Console.WriteLine("- " + lineItem.Qunatity + " x " + lineItem.Products.Name + " @ $" + lineItem.Products.Price + " each");
                }
            }
            Console.WriteLine("Total Price is :"+order1.CheckOutPrice);
           
        }
    }
}

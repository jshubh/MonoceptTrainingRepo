using ShoppingApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorShoppingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                
                Customer customer = new Customer(1, "Shubh jain");

                
                Product product1 = new Product(1, "Product 1", 100, 10);
                Product product2 = new Product(2, "Product 2", 200, 20);

                
                Order order1 = new Order();
                Order order2 = new Order();

                
                LineItem lineItem1 = new LineItem(product1, 2);
                LineItem lineItem2 = new LineItem(product2, 3);
                order1.AddLineItem(lineItem1);
                order1.AddLineItem(lineItem2);
            order1.AddLineItem(lineItem1);
            order2.AddLineItem(lineItem2);

                LineItem lineItem3 = new LineItem(product1, 1);
                LineItem lineItem4 = new LineItem(product2, 4);
                order2.AddLineItem(lineItem3);
                order2.AddLineItem(lineItem4);

                
                customer.AddOrder(order1);
                customer.AddOrder(order2);

                
                foreach (Order order in customer.Orders)
                {
                    Console.WriteLine($"Order ID: {order.Id}, Checkout Price: {order.CheckoutPrice}");
                }
            Console.WriteLine(order1.LineItemCount);
            Console.WriteLine(order2.LineItemCount);
            }

        }

    }
    


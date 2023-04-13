using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingApp.Model;
using System;

namespace ShoppingUnitTestApp
{
    [TestClass]
    public class TestAll
    {
        [TestMethod]
        
            public void TestCreateOrder()
            {
                Customer customer = new Customer(1, "Shubh Jain");
                Order order = new Order();
                customer.AddOrder(order);
                
                Assert.AreEqual(1, customer.Orders.Count);
            }
        [TestMethod]
            public void TestRemoveOrder()
            {
            Customer customer = new Customer(1, "Shubh jAIN");
            Order order = new Order();
            customer.RemoveOrder(order);
            Assert.AreEqual(0, customer.Orders.Count);

            }
        [TestMethod]
        public void TestLineItem()
        {
            Product product = new Product(1, "Shubh jAIN", 20, 0);
            LineItem lineItem = new LineItem(product, 2);
            Order order = new Order();
            order.AddLineItem(lineItem);
            int expectedOrderCount = 1;
            int exppectedPrice = 40;
            Assert.AreEqual(expectedOrderCount, order.Counts);
            Assert.AreEqual(exppectedPrice, order.CheckOutPrice);

        }
        [TestMethod]
        public  void TestRemoveLineItem()
        {
            Product product = new Product(1, "Shubh jAIN", 20, 0);
            LineItem lineItem = new LineItem(product, 2);
            Order order = new Order();
            order.AddLineItem(lineItem);
            int expectedOrderCount = 0;
            Assert.AreEqual(expectedOrderCount, order.Counts);

        }
        [TestMethod]
        public void TestCalculatePriceAfterDiscount()
        {
            Product product = new Product(1, "Shubh jAIN", 10,50);
            double expectedDiscount = 5;
               
            Assert.AreEqual(expectedDiscount, product.PriceAfterDiscount);

        }
        [TestMethod]
        public void TestCalculateItemCost()
        {
            Product product = new Product(1, "Product A", 10, 0);
            LineItem lineItem = new LineItem(product, 2);
            double expectedTotalPrice = 20;
            Assert.AreEqual(expectedTotalPrice, lineItem.TotalPrice);
        }

    }
    }


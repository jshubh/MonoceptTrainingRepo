using CustomerHashSet.Model;
using System;
using System.Collections.Generic;

namespace CustomerHashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CaseStuyd1();
            // CaseStudy2();
            CaseStudy3();
        }
        private static void CaseStuyd1()
        {
            HashSet<string> userNames = new HashSet<string>();
            userNames.Add("shubh");
            userNames.Add("Ankant");
            userNames.Add("shubh");
            foreach (string userName in userNames)
            {
                Console.WriteLine(userName);
            }
            Console.WriteLine(userNames.Count);

        }
        private static void CaseStudy3()
        {
            Customer c1 = new Customer(1, "Shubh");
            Customer c2 = new Customer(2, "ManjuNath");
            Customer c3 = new Customer(3, "Ravi");
            Customer c4 = new Customer(3, "Shubh");
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
            Console.WriteLine(c3.GetHashCode());
            Console.WriteLine(c4.GetHashCode());
            HashSet<Customer> customers = new HashSet<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);


            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name + " " + customer.Id);
            }
            Console.WriteLine(customers.Count);

        }
        private static void CaseStudy2()
        {
            HashSet<int> scores = new HashSet<int>();
            scores.Add(1);
            scores.Add(2);
            scores.Add(4);
            scores.Add(5);
            scores.Add(5);
            scores.Add(3);
            foreach (int score in scores)
            {
                Console.WriteLine(score);
            }
            Console.WriteLine(scores.Count);
        }
    }
}

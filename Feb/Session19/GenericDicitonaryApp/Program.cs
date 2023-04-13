using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDicitonaryApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();
        }
        private static void CaseStudy1()
        {
            Dictionary<string, string> stateCodes = new Dictionary<string, string>();

            stateCodes.Add("Mh", "Maharshtra");
            stateCodes.Add("Kl", "kerala");
            stateCodes.Add("Up", "Rampur");
            stateCodes.Add("KS", "Kerala");
            
            if(stateCodes.ContainsKey("Kl"))
            {
                stateCodes.Remove("Kl");
                stateCodes.Add("Kl", "New Kerala");
            }
            Console.WriteLine(stateCodes.Count);
            foreach(var row in stateCodes)
            {
                Console.WriteLine("Key is {0} -value is {1}", row.Key, row.Value);
            }
            stateCodes["M"] = "Mumbai";
            stateCodes["Mh"] = "Solapur";
            foreach (var row in stateCodes)
            {
                Console.WriteLine("Key is {0} -value is {1}", row.Key, row.Value);
            }
        }
    }
}

using GenricDynamicArray.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricDynamicArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DynamicClass<int> dynamicIntArray = new DynamicClass<int>(5);

            Console.WriteLine("Enter integers to add to the array. Enter a non-integer value to stop.");

            dynamicIntArray.ReadInput();

            Console.WriteLine($"Array contains {dynamicIntArray.Count} elements:");
            foreach (int value in dynamicIntArray.GetArray)
            {
                Console.WriteLine(value);
            }

            Console.ReadLine();
        }
    }
}

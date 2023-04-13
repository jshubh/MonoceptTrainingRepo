using CircleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circles circleA = new Circles(6.3f,"green","dotted");
            PrintDetails(circleA,"details of circle A");
            
           
            

        }
        static void PrintDetails(Circles circle ,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Radius is {circle.Radius}");
            Console.WriteLine($"Color is {circle.Color}");
            Console.WriteLine($"Border is {circle.Border}");
            Console.WriteLine($"Area is {circle.CalculateArea()}");


        }
    }
}

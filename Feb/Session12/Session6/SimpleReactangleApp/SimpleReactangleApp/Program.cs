using RectangleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleReactangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangelA;
            rectangelA = new Rectangle();
            PrintDetails(rectangelA, "details of RecatngelA without declartion");
          /*  Console.WriteLine($" width is {rectangelA.width}" + $"height is {rectangelA.height}" +
                $" color is  {rectangelA.color}" + $" area  is {rectangelA.CalculateArea()}" );
          */
            rectangelA.width = 10;
            rectangelA.height = 20;
            rectangelA.color = "Blue";
            PrintDetails(rectangelA, "details of Recatngle after declartion");

            /*Console.WriteLine($"width is {rectangelA.width}" + $"height is {rectangelA.height}" +
                $"color is {rectangelA.color}" + $" area  is {rectangelA.CalculateArea()}");
            
            */
            Rectangle rectangelB;
            rectangelB = rectangelA;
            PrintDetails(rectangelB, "details of RectangleB");
            /*
            Console.WriteLine("Reactangle B Details is");
            Console.WriteLine($"width is {rectangelB.width}" + $"height is {rectangelB.height}" +
                $"color is {rectangelB.color}" + $" area  is {rectangelB.CalculateArea()}");
            */
            
            rectangelB.color = "Yellow";

            Console.WriteLine($"Color of rectangle B is :{rectangelB.color}");
            Console.WriteLine($"Color of rectangle A is :{rectangelA.color}");






        }
        static void PrintDetails(Rectangle rectangel,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"width is {rectangel.width}" + $"height is {rectangel.height}" +
                $"color is {rectangel.color}" + $" area  is {rectangel.CalculateArea()}");
        }
    }
}

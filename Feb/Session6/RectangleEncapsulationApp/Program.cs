using RectangleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA = new Rectangle();
            rectangleA.SetHeight(5);
            rectangleA.SetWidth(4);
            rectangleA.SetColor("Blue");
            PrintDetails(rectangleA, "print all details of rectangleA");
            Rectangle rectangleB = new Rectangle();
            rectangleB.SetHeight(100);
            rectangleB.SetWidth(-1);
            rectangleB.SetColor("black");
            PrintDetails(rectangleA, "print all details of rectangleB");


        }
        static void PrintDetails(Rectangle rectangle,string descrption)
        {
            Console.WriteLine(descrption.ToUpper());
            Console.WriteLine($"width is {rectangle.GetWidth()}");
            Console.WriteLine($"height is {rectangle.GetHeight()}");
            Console.WriteLine($" color is {rectangle.GetColor()}");
            Console.WriteLine($"area is {rectangle.CalculateArea()}");
        }
    }
}

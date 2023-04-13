using RectanglePropertiesApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectanglePropertiesAppModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(new Rectangle(width: 10, height: 20, color: "red"), "details of first rectangle");
            Rectangle rectangleA = new Rectangle(100, 50, "green");
          //  rectangleA.Color="red";
            PrintDetails(rectangleA, "Rectangle A after color change");
        }
        static void PrintDetails(Rectangle rectangle, string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("width is :" + rectangle.Width);
            Console.WriteLine("Height is :" + rectangle.Height);

            Console.WriteLine("Color  is :" + rectangle.Color);
            Console.WriteLine("Area is :" + rectangle.CalculateArea());
        }


    }
}

using RectangleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintDetails(new Rectangle(width: 10, height: 20, color: "red"),"details of first rectangle");
            Rectangle rectangleA = new Rectangle(100, 50, "green");
            rectangleA.SetColor("red");
            PrintDetails(rectangleA, "Rectangle A after color change");
        }
        static void PrintDetails(Rectangle rectangle,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("width is :"+rectangle.GetWidth());
            Console.WriteLine("Height is :"+ rectangle.GetWidth());
            
            Console.WriteLine("Color  is :"+ rectangle.GetWidth());
            Console.WriteLine("Area is" + rectangle.CalculateArea());
        }
    }
}

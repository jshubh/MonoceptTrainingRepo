using RectangleApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle small;
            small = new Rectangle();
            small.height = 10;
            small.width = 10;
            Console.WriteLine("heigth of small reactangle",small.height);
            Console.WriteLine("width of small reactangle",small.width);

            Console.WriteLine("Small rectangelArea {0}",small.CalculateArea());

            
            Rectangle big;
            big = new Rectangle();
            big.height = 50;
            big.width= 100;
            Console.WriteLine("heigth of big reactangle",big.height);
            Console.WriteLine("width of big reactangle",big.width);
            Console.WriteLine("Big reactangle area {0}",big.CalculateArea());
           





        }
    }
}

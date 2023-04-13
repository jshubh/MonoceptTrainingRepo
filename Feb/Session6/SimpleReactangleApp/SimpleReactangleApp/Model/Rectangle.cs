using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp.Model
{
    internal class Rectangle
    {
        public int width;
        public int height;
        public string color;


        public int CalculateArea()
        {
            int area = width * height;
            return area;


        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp.Model
{
    internal class Rectangle
    {
        private  int _width;
        private   int _height;
        private string _color;

        public Rectangle(int width,int height,string color)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = ValidateColor(color);
        }

        private int ValidateSide(int side)
        {
            if (side > 100)
                return 100;
            else if (side < 0)
            {
                return 1;
            }
            else
                return side;
        }
        private string ValidateColor(string color)
        {
            if (color == "red" || color == "blue" || color == "green")
                return color;
            else
                return "red";
        }
        public int CalculateArea()
        {
            return _width * _height;
        }

        
     
        public void SetHeight(int pheight)
        {
           _height= Check(pheight);

        }
        public void SetColor(string pcolor)
        {
            _color = ValidateColor(pcolor);

        }
        public void SetWidth(int pwidth)
        {
            _width = Check(pwidth);
        }
        public int GetWidth()
        {
            return _width;
        }
        public int GetHeight()
        {
            return _height;

        }
        public string GetColor()

        {
            return _color;
        }
        public int Check(int paramet)
           
        {
            int a = 0;
            if (paramet> 100)
            {

                a = 100;
                return a;
               
            }
            else if (paramet < 0)
            {
                a = 1;
                return a;
               
            }
            else
            {
                a = paramet;
                return a;
                

            }
        }


    }
}

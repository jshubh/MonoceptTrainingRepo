using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp.Model
{
    internal class Rectangle
    {
        private int _width;
        private  int _height;
        private string _color;


        public int CalculateArea()
        {
            int area = _width * _height;
            return area;


        }
        public void SetHeight(int pheight)
        {
           _height= Check(pheight);

        }
        public void SetColor(string pcolor)
        {
            pcolor = pcolor.ToLower();
            if(pcolor=="red" || pcolor=="blue" || pcolor=="green")
            {
                _color = pcolor;
            }
            else
            {
                _color = "red";
            }

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

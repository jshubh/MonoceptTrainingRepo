using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp.Model
{
   
        public class Rectangle
        {
            protected int _width;
            protected int _height;

            public Rectangle(int width, int heigth)
            {
                _width=width;
                _height = heigth;
            }

        public int CalculateArea()
        {
            return _width * _height;
        }

        public  virtual  void SetWidth(int width)
        {
           _width= width;
        }

        public virtual void SetHeight(int height)
        {
           _height= height;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }
    }
}

            


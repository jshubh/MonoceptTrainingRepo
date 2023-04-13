using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp.Model
{
    internal class Square:Rectangle
    {
        public Square(int size):base(size,size)
        {

        }
        public override void SetHeight(int height)
        {
            _width = _height = height;
        }
        public override void SetWidth(int width)
        {
            _width = _height = width;
        }
    }
}

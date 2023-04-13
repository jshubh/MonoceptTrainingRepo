using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp.Model
{
    internal class Circles
    {
        private readonly float _radius;
       private string  _color;
        private string _borderStyle;

        public Circles(float radius,string color,string borderStyle)
        {
            _radius =ValidateSide(radius);
            _color = ValidateColor(color);
            _borderStyle = ValidateBorder(borderStyle);
        }
        public float CalculateArea()
        {
            float area = (float)(2 * 3.14 * _radius);
            return area;


        }
        public float ValidateSide(float pradius)
        {
            if(pradius>10)
            {
                return 10;
            }
            else if(pradius<0)
            {
                return 1;
            }
            else
            {
                return pradius;
            }
            

        }
        public string ValidateColor(string pcolor)
        {
            pcolor = pcolor.ToLower();
            if (pcolor == "red" || pcolor == "blue" || pcolor == "green")
            {

                return pcolor;
            }
            else
            {
                return "red";
            }

        }
        public string  ValidateBorder(string pborder)
        {
            pborder = pborder.ToLower();
            if(pborder=="dotted" || pborder=="double" || pborder=="line")
            {
                return pborder;
                

            }
            else
            {
                return "line";
            }

        }

        public float Radius
        {
            get{
                return _radius;
            
            }

        }
        public string Color

        {
            get{
                return _color;
            
            }

            set{

                _color = ValidateColor(value);
            }
        }
        public string Border
        {
            get
            {

                return _borderStyle;
            }


            set{
                _borderStyle = ValidateBorder(value);
            }
        }
    }
}

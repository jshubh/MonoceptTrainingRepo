using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorEventApp.Model
{
    public delegate void DCalculator(int n1,int n2, string str);
    internal class Calculator
    {
        public event DCalculator AdditionCompleted;
        public event DCalculator SubtractionCompleted;

        public void Add(int x, int y)
        {
            int result = x + y;
            string str = $"Addition is : {result}";
            if(AdditionCompleted != null)
            {
                AdditionCompleted(x,y,str);
            }
        }
        public void Subtract(int x, int y)
        {
            int result = x - y;
            string str = $"Subtraction is : {result}";
            if (SubtractionCompleted != null)
            {
                SubtractionCompleted(x,y,str);
            }
        }
    }
}

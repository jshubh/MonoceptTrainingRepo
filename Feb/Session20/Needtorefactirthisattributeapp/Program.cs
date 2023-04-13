using Needtorefactirthisattributeapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Needtorefactirthisattributeapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            NeedToRefactorAttribute.AttributeDisplay(typeof(Foo));

            Console.WriteLine();

            NeedToRefactorAttribute.AttributeDisplay(typeof(Bar));
        }
    }
}

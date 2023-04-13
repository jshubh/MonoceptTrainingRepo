using LSPViolationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(100, 20);
            ShouldNotChangeHeight_IfWidthIsModidfied(rectangle);

        }
        private static void ShouldNotChangeHeight_IfWidthIsModidfied(Rectangle rectange)
        {
            int beforecChange = rectange.GetHeight();
            rectange.SetWidth(rectange.GetWidth() + 10);
            int afterChange = rectange.GetHeight();
            Console.WriteLine(beforecChange==afterChange);
            Console.WriteLine(beforecChange);
            Console.WriteLine(afterChange);

        }
    }

}

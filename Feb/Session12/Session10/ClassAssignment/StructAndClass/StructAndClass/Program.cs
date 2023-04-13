using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace StructAndClass
{

  

    internal class Program
    {

        static void Main(string[] args)
        {

            CaseStudy2();

        }
            private static void CaseStudy1()
            {
                Car c1;

                // c1's data
                c1.Brand = "Bugatti";
                c1.Model = "Bugatti Veyron EB 16.4";
                c1.Color = "Gray";

                // Displaying the values
                Console.WriteLine("Name of brand: " + c1.Brand +
                                  "\nModel name: " + c1.Model +
                                  "\nColor of car: " + c1.Color);
            }
            private static void CaseStudy2()
            {
                ClassD obj = new ClassD();


                obj.Details("Ankita", "C#", 80, 50);
            }
        
        
    }
}

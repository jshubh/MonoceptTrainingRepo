using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnFacade.Model
{
    public class Transmission
    {
        public void ShiftToDrive()
        {
            Console.WriteLine("Transmission shifted to Drive.");
        }

        public void ShiftToPark()
        {
            Console.WriteLine("Transmission shifted to Park.");
        }
    }
}

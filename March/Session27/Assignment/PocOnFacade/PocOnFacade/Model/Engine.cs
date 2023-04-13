using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnFacade.Model
{
    public class Engine
    {
        public void TurnOn()
        {
            Console.WriteLine("Engine turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("Engine turned off.");
        }
    }
}

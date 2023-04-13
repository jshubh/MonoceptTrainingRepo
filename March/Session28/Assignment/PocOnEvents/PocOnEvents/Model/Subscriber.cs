using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnEvents.Model
{
    internal class Subscriber
    {
        public void HandleEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Event handled.");
        }
    }
}

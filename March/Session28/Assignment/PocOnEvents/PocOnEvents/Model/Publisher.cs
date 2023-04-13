using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnEvents.Model
{
    internal class Publisher
    {
        public event EventHandler MyEvent;

        public void TriggerEvent()
        {
            Console.WriteLine("Event triggered.");
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}

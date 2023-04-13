using PocOnEvents.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnEvents
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Publisher publisher = new Publisher();
            Subscriber subscriber = new Subscriber();

            
            publisher.MyEvent += subscriber.HandleEvent;

           
            publisher.TriggerEvent();
        }
    }
}

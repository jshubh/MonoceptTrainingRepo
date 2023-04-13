using ISPSolutionApp.Model;
using ISPVoilationApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
                var bot = new Robot();
                var manager = new Manager();

                AtTheCafeteria(manager);
              //  AtTheCafeteria(bot);

                AtTheWorkStation(manager);
                AtTheWorkStation(bot);
            }
            private static void AtTheCafeteria(IEat eater)
            {
                Console.WriteLine("At the Cafeteria");
                eater.StartEat();
                eater.StopEat();
                Console.WriteLine();
            }
            private static void AtTheWorkStation(IWork worker)
            {
                Console.WriteLine("At the Work Station");
                worker.StartWork();
                worker.StopWork();
                Console.WriteLine();
            }
        }
    }

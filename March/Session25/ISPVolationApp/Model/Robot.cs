using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPVoilationApp.Model
{
    internal class Robot : IWorker
    {
        public void StartEat()
        {
            throw new Exception("Robots Cannot Start Eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Robot Starts Working");
        }

        public void StopEat()
        {
            throw new Exception("Robots Cannot Stop Eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot Stops Working");
        }
    }
}

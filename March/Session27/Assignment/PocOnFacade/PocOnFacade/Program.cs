using PocOnFacade.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnFacade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFacade car = new CarFacade();
            car.StartCar();
            Console.WriteLine();
            car.StopCar();
        }
    }
}

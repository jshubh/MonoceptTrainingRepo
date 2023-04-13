using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PocOnFacade.Model
{
    public class CarFacade
    {
        private Engine engine;
        private Transmission transmission;
        private FuelInjector fuelInjector;

        public CarFacade()
        {
            engine = new Engine();
            transmission = new Transmission();
            fuelInjector = new FuelInjector();
        }

       
        public void StartCar()
        {
            engine.TurnOn();
            transmission.ShiftToDrive();
            fuelInjector.InjectFuel();
            Console.WriteLine("Car started!");
        }

        
        public void StopCar()
        {
            transmission.ShiftToPark();
            engine.TurnOff();
            Console.WriteLine("Car stopped.");
        }
    }
}

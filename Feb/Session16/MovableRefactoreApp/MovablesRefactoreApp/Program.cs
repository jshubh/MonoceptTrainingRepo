using MovablesRefactoreApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovablesRefactoreApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMovable[] movables =
            {
                new Car("Honda"),
                new Car("Bmw"),
                new Bike("Bajaj")
            };
            StartRace(movables);
        }
        static void StartRace(IMovable[] movables)
        {
            Console.WriteLine("Race started");

            foreach(IMovable movable in movables)
            {
                movable.Move();
            }
        }
    }
}


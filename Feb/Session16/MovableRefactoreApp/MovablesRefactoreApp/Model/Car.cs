using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovablesRefactoreApp.Model
{
    internal class Car:Vehicle
    {
        public Car(string name):base(name)
        {

        }

        public override void Move()
        {
            Console.WriteLine("Car is moving"+_name);
        }
    }
}

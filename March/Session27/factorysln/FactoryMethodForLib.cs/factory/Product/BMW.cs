using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryWithSingleton.Model
{
    internal class BMW : IAutoMobile
    {
        public void start()
        {
            Console.WriteLine("BmW starts");
        }

        public void stop()
        {
            Console.WriteLine("bMW stops");

        }
    }
}

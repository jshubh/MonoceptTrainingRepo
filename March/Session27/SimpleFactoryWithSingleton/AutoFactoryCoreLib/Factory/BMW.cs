using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFactoryCoreLib.Factory
{
    internal class BMW : IAutoMobile
    {
        public void start()
        {
            Console.WriteLine("BMW starts");
        }

        public void stop()
        {
            Console.WriteLine("BMW stops");

        }
    }
}

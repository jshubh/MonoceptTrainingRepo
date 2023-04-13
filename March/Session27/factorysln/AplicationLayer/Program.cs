using FactoryMethodForLib.cs.factory;
using SimpleFactoryWithSingleton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AplicationLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAutoMobileFactory factory1 = new BMWFactory();
            IAutoMobile auto = factory1.Make();
            auto.start();
            auto.stop();
        }
    }
}

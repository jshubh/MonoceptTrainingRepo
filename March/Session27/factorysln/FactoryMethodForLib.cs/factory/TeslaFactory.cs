using SimpleFactoryWithSingleton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodForLib.cs.factory
{
    public class TeslaFactory:IAutoMobileFactory
    {
        public IAutoMobile Make()
        {
            return new Tesla();
        }
    }
}

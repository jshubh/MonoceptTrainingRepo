using SimpleFactoryWithSingleton.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodForLib.cs.factory
{
    public class AudiFactory : IAutoMobileFactory
    {
        private static AudiFactory _instance;
        private AudiFactory() { }
        public IAutoMobile Make()
        {
            return new Audi();
        }
        public static AudiFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AudiFactory();
                    return _instance;
                }
                else return _instance;
            }
        }
    }
}

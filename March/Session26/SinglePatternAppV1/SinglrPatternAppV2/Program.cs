using SinglePatternAppV2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglrPatternAppV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service1 = DataService.GetInstance();
            service1.DoProcessing();
          
            var service2 = DataService.GetInstance();
            service2.DoProcessing();

            var service3 = DataService.GetInstance();
            service3.DoProcessing();

            Console.WriteLine(service1.GetHashCode());
            Console.WriteLine(service2.GetHashCode());
            Console.WriteLine(service3.GetHashCode());

        }
    }
}

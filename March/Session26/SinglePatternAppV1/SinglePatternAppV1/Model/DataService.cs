using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePatternAppV1.Model
{
    internal class DataService
    {
         private DataService()
        {
            Console.WriteLine("Data Service Created");
        }
        public void DoProcessing()
        {
            Console.WriteLine("Processing data by"+this.GetHashCode());
        }
        public static DataService GetInstance()
        {
            return new DataService();
        }
    }
}

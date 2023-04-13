using AppConfigUsingOOP.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigUsingOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ConnectionConfig connectionConfig = new ConnectionConfig();
            Console.WriteLine(connectionConfig.Connection1);
            Console.WriteLine(connectionConfig.Connection2);
            
        }
      
    }
}

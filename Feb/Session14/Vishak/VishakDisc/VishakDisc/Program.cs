using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using CustomerLib.Model;

namespace VishakDisc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("E:\\Monocept\\Ass\\customer1.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Object obj = binaryFormatter.Deserialize(fs);
            Customer s = obj as Customer;
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Id);
            
        }
    }
}

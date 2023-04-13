using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using HumanLib;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace HumanSeralizationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human("shubh", 22, 50,5.4f);
            h.Workout();
            h.Eat();
             FileStream fs = new FileStream("Human1.dump", FileMode.Create,FileAccess.Write);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fs,h);
            fs.Close();
            Console.WriteLine();

        }
    }
}

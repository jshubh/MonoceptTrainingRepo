using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using HumanLib;
using System.Threading.Tasks;

namespace HumanDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("Human1.dump", FileMode.Open, FileAccess.Read);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            object obj = binaryFormatter.Deserialize(fs);
            Human human = obj as Human;
            Console.WriteLine("name :" + human.Name);
            Console.WriteLine("Age :" + human.Age);
            Console.WriteLine("height :" + human.Height);
            Console.WriteLine("Weigth :" + human.Weight);
            fs.Close();

        }
    }
}

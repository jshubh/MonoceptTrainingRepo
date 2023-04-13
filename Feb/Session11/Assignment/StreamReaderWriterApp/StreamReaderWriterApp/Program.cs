using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace StreamReaderWriterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (StreamWriter sw = new StreamWriter(@"E:\\Monocept\\StreamAssignment\\TestFiles.txt"))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("How are You");
            }
            using (StreamReader sr = new StreamReader(@"E:\\Monocept\\StreamAssignment\\TestFiles.txt"))
            {
               
                string s;
                do
                {
                    s = sr.ReadLine();
                    Console.WriteLine(s);

                } while (s != null);

                Console.ReadLine();
            }

        }
      
       
    }
}

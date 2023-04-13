using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Model
{
    internal class Man
    {
        public virtual void Play()
        {
            Console.WriteLine("Man play chess");
        }
        public void Read()
        {
            Console.WriteLine("man read book");
        }
    }
}

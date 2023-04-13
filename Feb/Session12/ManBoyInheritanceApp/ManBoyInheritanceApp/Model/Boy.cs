using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Model
{
    internal class Boy:Man
    {
        public override void Play()
        {
            Console.WriteLine("boy play cricket");
        }
        public void Eat()
        {
            Console.WriteLine("boy eat apple");
        }
    }
}

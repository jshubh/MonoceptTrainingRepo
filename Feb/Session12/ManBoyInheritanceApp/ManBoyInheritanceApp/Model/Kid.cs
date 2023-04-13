using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManBoyInheritanceApp.Model
{
    internal class Kid:Man
    {
        public override void Play()
        {
            Console.WriteLine("kid is play");
        }
    }
}

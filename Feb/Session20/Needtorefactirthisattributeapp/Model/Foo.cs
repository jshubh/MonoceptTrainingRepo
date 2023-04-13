using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Needtorefactirthisattributeapp.Model
{
    internal class Foo
    {
        
        int id;
        string name;

        
        public Foo(int i, string n)
        {
            id = i;
            name = n;
        }

       
        [NeedToRefactorAttribute("id is","name is")]
        public int getId()
        {
            return id;
        }

        
        [NeedToRefactorAttribute("id is","name")]
        public string getName()
        {
            return name;
        }
    }
}

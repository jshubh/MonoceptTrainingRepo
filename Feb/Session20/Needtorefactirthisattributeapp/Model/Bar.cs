using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Needtorefactirthisattributeapp.Model
{
    internal class Bar
    {
       
        int id;
        string name;

        public Bar(int i, string n)
        {
            id = i;
            name = n;
        }

      
        [NeedToRefactorAttribute("Its modified the data")]
        public int getId()
        {
            return id;
        }


        [NeedToRefactorAttribute("Its modified the data")]
        public string getName()
        {
            return name;
        }
    }
}

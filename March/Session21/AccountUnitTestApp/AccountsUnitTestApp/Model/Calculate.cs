using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountsUnitTestApp.Model
{
    public class Calculate
    {

        public int CubeOnlyEvenNumber(int number)
        {
            if (number % 2 == 0)
            {
                return number * number * number;
            }
            return -1;
        }
        public int Add(params int[] num)
        {
            int result = 0;
            foreach(int i in num)
            {
                result += i;
            }
            return result;
        }

    }

}

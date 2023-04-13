using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddProject.Model
{
    internal class Odd
    {
      public  int [] GetOdd(int n)
        {
            int []a = new int[n / 2];
            int  k = 0;
            for (int i = 1; i <= n; i += 2)
            {
                a[k++] = i;
            }
           
            return a;

        }
      public  int[]  GetOdd(int starting ,int ending)
        {
            int[] a1 = new int[(ending-starting+1)/2];
            int k = 0;
            for (int i = starting; i <= ending; i++)
            {
                if (i % 2 == 1)
                {
                    a1[k++] = i;
                }
            }
            return a1;

        }
    }
    
}

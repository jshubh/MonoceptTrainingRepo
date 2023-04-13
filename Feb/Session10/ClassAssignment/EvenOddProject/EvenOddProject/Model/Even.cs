using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddProject.Model
{
    internal class Even
    {
      public  void GetEven(int n)
        {
            int[] a = new int[n / 2];
            int k = 0;
            for (int i = 2; i <= n; i += 2)
            {
                a[k++] = i;
            }
            for(int i=2;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }

        }
     public void GetEven(int starting, int ending)
        {
            int[] a1 = new int[(ending - starting + 1) / 2+1];
            int k = 0;
            for (int i = starting; i <= ending; i++)
            {
                if (i % 2 == 0)
                {
                    a1[k++] = i;
                }
            }
            for (int i = 2; i <a1.Length ; i++)
            {
                Console.Write(a1[i] + " ");
            }

        }
    }
}

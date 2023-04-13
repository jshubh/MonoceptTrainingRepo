using DynamicArrayOOP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            DynamicClass dynamicClass = new DynamicClass(5);
            dynamicClass.ReadInput();
            int []arr = dynamicClass.GetArray;
            int count = dynamicClass.Count;
            for(int i=0;i<count;i++ )
            {
                Console.WriteLine(arr[i]);
            }



            
        }
      
    }
}

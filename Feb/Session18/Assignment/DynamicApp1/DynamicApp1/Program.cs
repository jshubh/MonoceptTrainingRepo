using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int count = 0;
            bool Exit = false;
            while(!Exit)
            {
                Console.WriteLine("Enter a no");
                string input = Console.ReadLine();
                if(!(int.TryParse(input, out int value)))
                    {
                    Exit = true;
                   }
                else
                {
                    arr[count] = value;
                    count++;
                    if(count==arr.Length)
                    {
                        Console.WriteLine("Resize Array");
                        int[] arr1 = new int[arr.Length * 2];
                        Array.Copy(arr, arr1, arr.Length);
                        arr = arr1;
                    }
                }

            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(arr[i]);
                   
            }
            
        }
    }
}

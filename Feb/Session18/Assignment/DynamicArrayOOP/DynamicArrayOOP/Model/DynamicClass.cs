using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrayOOP.Model
{
    internal class DynamicClass
    {

        private int[] arr;
        public int count;

        public DynamicClass(int initialSize)
        {
            arr = new int[initialSize];
            count = 0;
        }

        public void ReadInput()
        {
            bool Exit = false;
            while (!Exit)
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int value))
                {
                   Exit = true;
                }
                else
                {
                    Add(value);
                }
            }
        }

        private void Add(int value)
        {
            if (count == arr.Length)
            {
                Resize();
            }
            arr[count] = value;
            count++;
        }

        public int [] Resize()
        {
            Console.WriteLine("Resize array...");
            int[] newArr = new int[arr.Length * 2];
            Array.Copy(arr, newArr, arr.Length);
            arr = newArr;

            return arr;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public int[] GetArray
        {
            get
            {
                return arr;
            }
        }
     

    }
}

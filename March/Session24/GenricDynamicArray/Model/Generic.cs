using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricDynamicArray.Model
{
    internal class DynamicClass<T>
    {
        private T[] arr;
        public int count;

        public DynamicClass(int initialSize)
        {
            arr = new T[initialSize];
            count = 0;
        }

        public void ReadInput()
        {
            bool Exit = false;
            while (!Exit)
            {
                Console.WriteLine("Enter a value:");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Exit = true;
                }
                else
                {
                    if (TryParse(input, out T value))
                    {
                        Add(value);
                    }
                    else
                    {
                        Exit = true;
                    }
                }
            }
        }

        private void Add(T value)
        {
            if (count == arr.Length)
            {
                Resize();
            }
            arr[count] = value;
            count++;
        }

        private void Resize()
        {
            Console.WriteLine("Resize array...");
            T[] newArr = new T[arr.Length * 2];
            Array.Copy(arr, newArr, arr.Length);
            arr = newArr;
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public T[] GetArray
        {
            get
            {
                return arr;
            }
        }

        private bool TryParse(string s, out T result)
        {
            try
            {
                result = (T)Convert.ChangeType(s, typeof(T));
                return true;
            }
            catch
            {
                result = default(T);
                return false;
            }
        }
    }


}



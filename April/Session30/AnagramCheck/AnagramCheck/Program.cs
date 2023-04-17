using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "race";
            string str2 = "care";


            char[] charArray1 = str1.ToCharArray();
            char[] charArray2 = str2.ToCharArray();


            Array.Sort(charArray1);
            Array.Sort(charArray2);

            string sortedStr1 = new string(charArray1);
            string sortedStr2 = new string(charArray2);


            if (sortedStr1 == sortedStr2)
            {
                Console.WriteLine("The strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The strings are not anagrams.");
            }
        }
    }
}

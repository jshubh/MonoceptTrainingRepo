using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoleDiceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

         
            Dictionary<int, int> diceCounts = new Dictionary<int, int>();

            for (int i=0; i < 10;i++)
                {
                int diceRoll = random.Next(1, 7);
                if(diceCounts.ContainsKey(diceRoll))
                {
                    diceCounts[diceRoll]++;
                }
                else
                {
                    diceCounts[diceRoll] = 1;
                }

               }
          
           

           
            foreach (var row in diceCounts)
            {
                Console.WriteLine("key and value is  {0} {1}", row.Key, row.Value);
            }
        }
    }

}

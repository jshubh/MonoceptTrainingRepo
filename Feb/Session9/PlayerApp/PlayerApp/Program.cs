using PlayerApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] play1 = new Player[5];
            play1[0] = new Player(1, 23, "Shubh");
            




            
            

        }
        private static void CaseStudy1()
        {
            Player Sachin = new Player(1, 22, "Sachin");
            Player virat = new Player(5, "Virat");
            Player elder = Sachin.WhoIsElder(virat);


            Console.WriteLine(elder.Name);
            Console.WriteLine("sachin hash" + Sachin.GetHashCode());
            Console.WriteLine("virat hash:" + virat.GetHashCode());
            Console.WriteLine("elder hash:" + elder.GetHashCode());
        }
        private static void CaseStudy2()
        {
            Player playerA = new Player(12, 22, "Shubh");
            Player playerB = new Player(15, "Rahul");

            PrintDetails(playerA, "Details of player 1");
            PrintDetails(playerB, "Details of player 2");

        }
        static void PrintDetails(Player player,string description)
        {
           
            Console.WriteLine(description.ToUpper());
            Console.WriteLine("id is:" + player.Id);
            Console.WriteLine("Name is:" + player.Name);
            Console.WriteLine("Age  is:" + player.Age);
        }
       
    }
}

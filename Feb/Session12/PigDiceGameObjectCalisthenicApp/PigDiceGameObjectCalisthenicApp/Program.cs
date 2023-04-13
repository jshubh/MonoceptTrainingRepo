using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGameObjectCalisthenicApp
{
    internal class Program
    {
      
        public static int turnScore;
        public static int totalScore;
        public static int turnno;
        static void Main(string[] args)
        {
            Console.WriteLine("Let's Play PIG!\n");
            Console.WriteLine("* See how many turns it takes you to get to 20.");
            Console.WriteLine("* Turn ends when you hold or roll a 1.");
            Console.WriteLine("* If you roll a 1, you lose all points for the turn.");
            Console.WriteLine("* If you hold, you save all points for the turn.\n");
            bool turn = true;
            while (turn)
            {
                CheckTurn(ref turn);
                return;
            }
        }
        private static void CheckTurn(ref bool turn1)
        {
            bool gameOver = false;
            while (!gameOver)
            {
                RollDice(ref turnno);
                if (gameOver == true)
                {
                    turn1 = false;
                    return;
                }
            }
        }

        private static void RollDice(ref int turnno)
        {
            Console.WriteLine();
            Console.WriteLine($"TURN {turnno + 1}:\n");
            Console.Write("Enter 'r' to roll again, 'h' to hold.\n");
            string choice = Console.ReadLine().ToLower();
            bool gameOver = false;
            Random rnd = new Random();
            if (choice == "r")
            {

                int rollvalue = rnd.Next(1, 7);

                if (rollvalue == 1)
                {
                    Console.WriteLine($"You rolled: {rollvalue}");
                    Console.WriteLine($"Turn over. No Score\n");
                    turnScore = 0;
                    turnno++;
                }
                else
                {

                    turnScore += rollvalue;
                    Console.WriteLine($"You rolled: {rollvalue}");
                    Console.WriteLine($"Your turn score is {turnScore} and your total score is {totalScore}");
                    gameOver = CheckTotalValue(turnno, ref gameOver);
                    Console.Write("If you hold, you will have ");
                    Console.WriteLine($"{totalScore + turnScore} points.");
                }
            }
            else
            {
                if (choice == "h")
                {
                    totalScore += turnScore;
                    Console.WriteLine($"\nYour turn score is {totalScore} and your total score is {totalScore}\n");
                    turnScore = 0;
                    turnno++;
                }
            }
            return;
        }

        private static bool CheckTotalValue(int turnno, ref bool gameOver)
        {
            if (totalScore + turnScore >= 20)
            {
                Console.WriteLine($"Your turn score is {turnScore} and your total score is {totalScore + turnScore}");
                Console.WriteLine($"You Win! You finished in {turnno} turns!\n");
                gameOver = true;
                System.Environment.Exit(0);
            }
            return gameOver;
        }
    }
}
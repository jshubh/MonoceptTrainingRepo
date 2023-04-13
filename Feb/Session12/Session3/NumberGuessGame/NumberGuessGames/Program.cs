using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int guess = 0;
            int numberOfGuesses = 0;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            

                while (guess != numberToGuess)
                {
                    Console.Write("Enter your guess (between 1 and 100): ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    numberOfGuesses++;

                    if (guess < numberToGuess)
                    {
                        Console.WriteLine("Too low. Guess higher.");
                    }
                    else if (guess > numberToGuess)
                    {
                        Console.WriteLine("Too high. Guess lower.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number {numberToGuess} in {numberOfGuesses} attempts.");
                    }
                }

                Console.ReadLine();
            }
        }
    }

        
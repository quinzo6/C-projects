// Simple C# Rock paper scissors project

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(2000);
            Console.WriteLine("Choose Rock, Paper, or Scissors!");

            string userChoice = Console.ReadLine();
            string[] type = new string[] { "Paper", "Rock", "Scissors" };
            Random rand = new Random();
            int index = rand.Next(type.Length);
            string result = type[index];


            if (userChoice == "Rock")
            {
                Console.WriteLine($"I choose {result}!");
                if (result == "Rock" && userChoice == "Rock")
                {
                    Console.WriteLine("Its a tie!");
                    Console.ReadLine();
                }

                if (result == "Paper" && userChoice == "Rock")
                {
                    Console.WriteLine("I win!");
                    Console.ReadLine();
                }

                if (result == "Scissors" && userChoice == "Rock")
                {
                    Console.WriteLine("You win!");
                    Console.ReadLine();
                }
            }

            if (userChoice == "Paper")
            {
                    Console.WriteLine($"I choose {result}!");
                    if (result == "Paper" && userChoice == "Paper")
                    {
                        Console.WriteLine("Its a tie!");
                        Console.ReadLine();
                    }

                    if (result == "Rock" && userChoice == "Paper")
                    {
                        Console.WriteLine("You win!");
                        Console.ReadLine();
                    }

                    if (result == "Scissors" && userChoice == "Paper")
                    {
                        Console.WriteLine("I win!");
                        Console.ReadLine();
                    }
            }

            if (userChoice == "Scissors")
            {
                Console.WriteLine($"I choose {result}!");
                if (result == "Paper" && userChoice == "Scissors")
                {
                    Console.WriteLine("You win!");
                    Console.ReadLine();
                }

                if (result == "Rock" && userChoice == "Scissors")
                {
                    Console.WriteLine("I win!");
                    Console.ReadLine();
                }

                if (result == "Scissors" && userChoice == "Scissors")
                {
                    Console.WriteLine("Its a tie!");
                    Console.ReadLine();
                }
            }
        }
    }
}

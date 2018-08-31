using System;

namespace Selections
{
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissors.PlayGame();
            RandomMonthGenerator.GenerateMonth();
            QuadraticEquation.PromptForConstants();
            PickACard.GetACard();
        }

        private static void Example2(int x)
        {
            switch (Math.Abs(x%2))
            {
                case 0: Console.WriteLine("Even number");break;
                case 1: Console.WriteLine("Odd number"); break;
                default: Console.WriteLine("Number unknown");break;
            }
        }

        private static void Example3(int numberOfTosses)
        {
            const string HEADS = "HEADS";
            const string TAILS = "TAILS";
            Random r = new Random();
            //HEADS =1, TAILS =0
      
            for (int i = 0; i < numberOfTosses; i++)
            {
                Console.WriteLine(Math.Floor(r.Next() * 2m) == 1 ? HEADS : TAILS);
            }
            
        }

        private static void Example1(int x)
        {
            Console.WriteLine(x % 2 == 0 ? "Even number" : "Odd number");
        }
    }
}

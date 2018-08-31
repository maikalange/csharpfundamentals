using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selections
{
    class RockPaperScissors
    {
        private enum Option
        {
            Scissors,
            Rock,
            Paper
        }

        public static void PlayGame()
        {
            var random  = new Random();
  
            var computersOption = (int) Math.Floor(random.NextDouble()* 3) ;
            Console.WriteLine("Scissors(0), Rock(1), Paper(2):");
            var k = Console.ReadLine();

            if (Int32.TryParse(k, out int humansOption))
            {
                if (humansOption >= 0&& humansOption<=2)
                {
                    if (computersOption == humansOption)
                    {
                        Console.WriteLine("The computer is {0}. You are {0} too . You draw with the computer", Enum.GetName(typeof(Option),computersOption));
                    }
                    else switch (computersOption)
                        {
                            case (int)Option.Scissors:
                                switch (humansOption)
                                {
                                    case (int)Option.Rock:
                                        Console.WriteLine("The computer is scissors. You are rock. You win.");
                                        break;
                                    case (int)Option.Paper:
                                        Console.WriteLine("The computer is scissors. You are paper. You lose.");
                                        break;
                                }

                                break;
                            case (int)Option.Rock:
                                switch (humansOption)
                                {
                                    case (int)Option.Scissors:
                                        Console.WriteLine("The computer is rock. You are scissors. You lose.");
                                        break;
                                    case (int)Option.Paper:
                                        Console.WriteLine("The computer is rock. You are paper. You win.");
                                        break;
                                }

                                break;
                            case (int)Option.Paper:
                                switch (humansOption)
                                {
                                    case (int)Option.Scissors:
                                        Console.WriteLine("The computer is paper. You are scissors. You win.");
                                        break;
                                    case (int)Option.Rock:
                                        Console.WriteLine("The computer is paper. You are rock. You win");
                                        break;
                                }

                                break;
                        }
                }
                Console.WriteLine("You entered a value out of range.");
            }
        }
    }
}
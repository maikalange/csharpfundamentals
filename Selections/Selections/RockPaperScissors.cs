using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selections
{
    class RockPaperScissors
    {
        enum MyEnum
        {
            Scissors,
            Rock,
            Paper
        }

        public static void PlayGame()
        {
            var random  = new Random();
  
            var computersValue = (int) Math.Floor(random.NextDouble()* 3) ;
            Console.WriteLine("Scissors(0), Rock(1), Paper(2):");
            var k = Console.ReadLine();

            if (Int32.TryParse(k, out int humansValue))
            {
                if (humansValue >= 0&& humansValue<=2)
                {
                    if (computersValue == humansValue)
                    {
                        Console.WriteLine("The computer is {0}. You are {0} too . You draw with the computer", Enum.GetName(typeof(MyEnum),computersValue));
                    }
                    else if (computersValue == (int)MyEnum.Scissors)
                    {
                        switch (humansValue)
                        {
                            case (int)MyEnum.Rock:
                                Console.WriteLine("The computer is scissors. You are rock. You win.");
                                break;
                            case (int)MyEnum.Paper:
                                Console.WriteLine("The computer is scissors. You are paper. You lose.");
                                break;
                        }
                    }
                    else if (computersValue == (int)MyEnum.Rock)
                    {
                        switch (humansValue)
                        {
                            case (int)MyEnum.Scissors:
                                Console.WriteLine("The computer is rock. You are scissors. You lose.");
                                break;
                            case (int)MyEnum.Paper:
                                Console.WriteLine("The computer is rock. You are paper. You win.");
                                break;
                        }
                    }
                    else if (computersValue == (int)MyEnum.Paper)
                    {
                        switch (humansValue)
                        {
                            case (int)MyEnum.Scissors:
                                Console.WriteLine("The computer is paper. You are scissors. You win.");
                                break;
                            case (int)MyEnum.Rock:
                                Console.WriteLine("The computer is paper. You are rock. You win");
                                break;
                        }
                    }
                }
                Console.WriteLine("You entered a value out of range.");
            }
        }
    }
}
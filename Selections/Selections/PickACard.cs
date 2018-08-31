using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selections
{
    class PickACard
    {
        public static void GetACard()
        {
            int[] rank = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
            string[] suit = {"Clubs", "Diamonds", "Hearts", "Spades"};

            int randomRank = rank[(int) Math.Floor(new Random().NextDouble() * rank.Length)];
            string randomSuit = suit[(int) Math.Floor(new Random().NextDouble() * suit.Length)];

            string rankName;
            if (randomRank==11)
            {
                rankName = " Jack";
            }else if (randomRank == 12)
            {
                rankName = " Queen";
            }
            else if (randomRank == 13)
            {
                rankName = " King";
            }
            else if (randomRank == 1)
            {
                rankName = " Ace";
            }
            else
            {
                rankName = randomRank.ToString();
            }

           Console.WriteLine($"The card you picked is {rankName} of {randomSuit}");
               
        }
    }
}

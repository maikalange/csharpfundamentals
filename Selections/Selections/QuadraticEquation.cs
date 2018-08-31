using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selections
{
    class QuadraticEquation
    {
        public static void PromptForConstants()
        {
            Console.WriteLine("Enter the value for a, b and C");
            String constants  = Console.ReadLine();
            String[] values  = constants.Split(new char []{ ' '});
            if (values.Length == 3)
            {
                var a = values[0];
                var b = values[1];
                var c = values[2];
            }

        }



        private static bool IsRealRoots()
        {
            return false;
        }
    }
}

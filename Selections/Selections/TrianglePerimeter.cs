using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selections
{
    class TrianglePerimeter
    {
        //This class introduces potential issues with invalid input. Not robust, learners to identify issues in discussion and refactor
        private static decimal A { get; set; }
        private static decimal B { get; set; }
        private static decimal C { get; set; }

        public static void CalculatePerimeter()
        {
            Console.WriteLine("Enter the sides of the rectangle: A, B and C");
            string sides  =Console.ReadLine();
            string[]values  = sides.Split(new char[] {' '});
            //Not ideal look at the problems presented by taking this approach
            A = Convert.ToDecimal(values[0]);
            B = Convert.ToDecimal(values[1]);
            C = Convert.ToDecimal(values[2]);

            if (SidesAreValid())
            {
                var perimeter = A + B + C;
                Console.WriteLine($"The perimeter of the triangle is :{perimeter}");
            }
            else
            {
                Console.WriteLine("The triangle geometry is not valid");
            }
        }

        private static bool SidesAreValid()
        {
            bool isValidSideC = A + B > C;
            bool isValidSideA = C + B > A;
            bool isValidSideB = A + C > B;


            return isValidSideB && isValidSideA && isValidSideC;
        }
    }
}

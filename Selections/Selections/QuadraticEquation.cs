using System;
using System.Linq;

namespace Selections
{
    class QuadraticEquation
    {
        public static void PromptForConstants()
        {
            Console.WriteLine("Enter the value for a, b and c separated by a space");
            String constants = Console.ReadLine();
            if (constants != null)
            {
                String[] values = constants.Split(new char[] { ' ' });
                if (values.Length == 3)
                {

                    bool validC = Double.TryParse(values[2], out double c);
                    bool validB = Double.TryParse(values[1], out double b);
                    bool validA = Double.TryParse(values[0], out double a);

                    if (validB && validC && validA)
                    {
                        if (IsRealRoots(a, b, c))
                        {
                            double[] roots = CalculateRoots(a, b, c);

                            foreach (var root in roots)Console.WriteLine(root);
                        }
                        else
                        {
                            Console.WriteLine("Unable to calculate complex roots");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid values");
                    }
                }

            }
            else
            {
                Console.WriteLine("Unable to calculate the roots. Please enter valid values");
            }
        }

        private static double[] CalculateRoots(double a, double b, double c)
        {
            double determinant = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);

            double negativeRoot = (-b - determinant) / 2 * a;
            double positiveRoot = (-b + determinant) / 2 * a;

            return new double[] { negativeRoot, positiveRoot };
        }



        private static bool IsRealRoots(double a, double b, double c) => Math.Pow(b, 2) - 4 * a * c >= 0;
    }
}

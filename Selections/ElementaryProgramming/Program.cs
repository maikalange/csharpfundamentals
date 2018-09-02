using System;

namespace ElementaryProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateFutureInvestment();
        }


        private static void CalculateFutureInvestment()
        {
            Console.WriteLine("Enter investment value");
            var x = Console.ReadLine();
            var isValidAmount  = double.TryParse(x, out var value);
            Console.WriteLine("Enter the number of years");
            var y = Console.ReadLine();
            Console.WriteLine("Enter the annual interest rate in percentage");
            var z = Console.ReadLine();


            var isValidInterest  = double.TryParse(z, out double monthlyInterest);
            var isValidYears = double.TryParse(y, out double numberOfYears);

            if (isValidAmount&&isValidInterest&&isValidYears)
            {
                var f = value * Math.Pow((1 + monthlyInterest/(12*100)), numberOfYears * 12);
                Console.WriteLine($"Accumulated value is:{f:C}");
               
            }
            else
            {
                Console.WriteLine("Unable to complete your request. Please check your inputs.");
            }

        }
    }
}

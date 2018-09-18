using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.BLL.FizzBuzz.Services
{
    public class FizzBuzzService
    {
        public void DoFizzBuzz(string value)
        {
            var numericValue = int.Parse(value);

            for (var i = 1; i < numericValue; i++)
            {
                var isDivisibleByThree = IsDivisible(i, 3);
                var isDivisibleByFive = IsDivisible(i, 5);

                if (isDivisibleByThree && isDivisibleByFive)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (isDivisibleByThree)
                {
                    Console.WriteLine("Fizz");
                }
                else if (isDivisibleByFive)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsDivisible(int generatedValue, int divider)
        {
            return generatedValue % divider == 0;
        }
    }
}
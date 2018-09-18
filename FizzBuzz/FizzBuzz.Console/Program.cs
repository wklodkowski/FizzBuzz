using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.BLL.FizzBuzz.Services;

namespace FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter a value between 1 and 1000");
            var enterValue = System.Console.ReadLine();
            var fizzBuzz = new FizzBuzzService();
            fizzBuzz.DoFizzBuzz(enterValue);
            System.Console.ReadKey();
        }
    }
}

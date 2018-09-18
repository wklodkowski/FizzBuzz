using FizzBuzz.BLL.FizzBuzz.Services;
using NUnit.Framework;

namespace FizzBuzz.BLL.Tests.FizzBuzz.Services
{
    [TestFixture]
    public class FizzBuzzServiceTests
    {
        [Test]
        public void DoFizzBuzz_DivideByThree_PrintFizz()
        {
            var fizzBuzzService = new FizzBuzzService();
            
        }

        [Test]
        public void DoFizzBuzz_DivideByThree_PrintBuzz()
        {
            var fizzBuzzService = new FizzBuzzService();

        }

        [Test]
        public void DoFizzBuzz_DivideByThreeAndFive_PrintFizzBuzz()
        {
            var fizzBuzzService = new FizzBuzzService();

        }

        [Test]
        public void DoFizzBuzz_NotDivideByThreeOrFive_PrintNumber()
        {
            var fizzBuzzService = new FizzBuzzService();

        }
    }
}

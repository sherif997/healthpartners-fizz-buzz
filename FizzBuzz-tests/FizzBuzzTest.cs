using fizzbuzz_app;
using fizzbuzz_app.Interfaces;
using fizzbuzz_app.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FizzBuzz_tests
{
    public class FizzBuzzTests
    {
        private ServiceProvider serviceProvider;
        FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup()
        {
            var services = new ServiceCollection()
                .AddSingleton<IRuleService, RuleService>()
                .AddTransient<FizzBuzz>()
                .BuildServiceProvider();

            fizzBuzz = services.GetService<FizzBuzz>();
        }

        [Test]
        public void NumberNotDivisibleByThreeOrFive()
        {
            var input = 1;
            var actualResult = fizzBuzz.GetResult(input);
            Assert.AreEqual(input.ToString(), actualResult);
        }

        [Test]
        public void NumberDivisibleByThree()
        {
            var input = 9;
            var actualResult = fizzBuzz.GetResult(input);
            var expectedResult = "Fizz";
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void NumberDivisibleByFive()
        {
            var input = 20;
            var expectedResult = "Buzz";
            var actualResult = fizzBuzz.GetResult(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void NumberDivisibleByThreeAndFive()
        {
            var input = 15;
            var expectedResult = "FizzBuzz";
            var actualResult = fizzBuzz.GetResult(input);
            Assert.AreEqual(expectedResult, actualResult);
        }


    }
}
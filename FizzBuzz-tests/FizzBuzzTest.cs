using fizzbuzz_app;

namespace FizzBuzz_tests
{
    public class FizzBuzzTests
    {
        FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup()
        {
           fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void NumberNotDivisibleByThreeOrFive()
        {
            var input = 1;
            var actualResult = fizzBuzz.getResult(input);
            Assert.Equals(input, actualResult);
        }

        [Test]
        public void NumberDivisibleByThree()
        {
            var input = 9;
            var actualResult = fizzBuzz.getResult(input);
            var expectedResult = "Fizz";
            Assert.Equals(expectedResult, actualResult);
        }

        [Test]
        public void NumberDivisibleByFive()
        {
            var input = 20;
            var expectedResult = "Buzz";
            var actualResult = fizzBuzz.getResult(input);
            Assert.Equals(expectedResult, actualResult);
        }

        [Test]
        public void NumberDivisibleByThreeAndFive()
        {
            var input = 15;
            var expectedResult = "FizzBuzz";
            var actualResult = fizzBuzz.getResult(input);
            Assert.Equals(expectedResult, actualResult);
        }


    }
}
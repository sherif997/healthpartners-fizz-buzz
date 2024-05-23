using fizzbuzz_app.Interfaces;
using fizzbuzz_app.Services;
using Microsoft.Extensions.DependencyInjection;

namespace fizzbuzz_app
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IRuleService, RuleService>()
                .AddTransient<FizzBuzz>()
                .BuildServiceProvider();

            var fizzBuzz = serviceProvider.GetService<FizzBuzz>();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzBuzz.GetResult(i));
            }
        }
    }
}

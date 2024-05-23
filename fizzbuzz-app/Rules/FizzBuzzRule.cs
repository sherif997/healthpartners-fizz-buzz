using fizzbuzz_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz_app.Rules
{
    public class FizzBuzzRule : IRule
    {
        public string CheckInput(int number)
        {
           return (number % 3 == 0 && number % 5 == 0) ? "FizzBuzz" : null;
        }
    }
}

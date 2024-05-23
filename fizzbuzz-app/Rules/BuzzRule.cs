using fizzbuzz_app.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz_app.Rules
{
    public class BuzzRule : IRule
    {
        public string CheckInput(int number)
        {
            return number % 5 == 0 ? "Buzz" : null;
        }
    }
}

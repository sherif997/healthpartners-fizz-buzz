using fizzbuzz_app.Interfaces;
using fizzbuzz_app.Rules;


namespace fizzbuzz_app
{
    public class FizzBuzz
    {
        private IEnumerable<IRule> _rules;
        private  IRuleService _ruleService;
        public FizzBuzz(IRuleService ruleService)
        {
            _ruleService = ruleService;
            _rules = _ruleService.LoadRules();

        }

        public string GetResult(int number)
        {
            _rules = _ruleService.LoadRules();
            foreach (var rule in _rules)
            {
                var result = rule.CheckInput(number);
                if (result != null)
                {
                    return result;
                }
            }

            return number.ToString();
        }
    }
}

using fizzbuzz_app.Interfaces;
using fizzbuzz_app.Rules;


namespace fizzbuzz_app.Services
{
    public class RuleService: IRuleService
    {
        public IEnumerable<IRule> LoadRules()
        {
            var ruleTypes = new List<Type>
            {
                typeof(FizzBuzzRule), // Ensure FizzBuzzRule is loaded first
                typeof(FizzRule),
                typeof(BuzzRule),
                typeof(DefaultRule)
            };

            var rules = new List<IRule>();

            foreach (var type in ruleTypes)
            {
                rules.Add((IRule)Activator.CreateInstance(type));
            }

            return rules;
        }
    }
}

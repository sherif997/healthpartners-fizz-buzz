using fizzbuzz_app.Interfaces;
using fizzbuzz_app.Rules;
using System.Reflection;

namespace fizzbuzz_app.Services
{
    public class RuleService: IRuleService
    {
        public IEnumerable<IRule> LoadRules()
        {
            var ruleTypes = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => typeof(IRule).IsAssignableFrom(type) && type.IsClass && !type.IsAbstract)
                .OrderByDescending(type => type.Name == "FizzBuzzRule" ? 2 : type.Name == "DefaultRule" ? 0 : 1)
                .ThenBy(type => type.Name);

            var rules = new List<IRule>();

            foreach (var type in ruleTypes)
            {
                rules.Add((IRule)Activator.CreateInstance(type));
            }

            return rules;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz_app.Interfaces
{
    public interface IRuleService
    {
        public IEnumerable<IRule> LoadRules();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzProjet

{
    public class FizzBuzzProcessor
    {
        private readonly IEnumerable<IFizzBuzzRule> _rules;

        public FizzBuzzProcessor(IEnumerable<IFizzBuzzRule> rules)
        {
            _rules = rules;
        } //

        public string Process(int number)
        {
            foreach (var rule in _rules)
            {
                if (rule.IsMatch(number))
                {
                    return rule.GetResult(number);
                }
            }
            return string.Empty;
        }
    }
}

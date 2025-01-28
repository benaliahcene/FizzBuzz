using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzProjet
{
    public class FizzBuzzRule : IFizzBuzzRule
    {
        public bool IsMatch(int number) => number % 3 == 0 && number % 5 == 0;
        public string GetResult(int number) => "FizzBuzz"; //
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzProjet
{
    public interface IFizzBuzzRule
    {
        bool IsMatch(int number);
        string GetResult(int number); //
    }
}

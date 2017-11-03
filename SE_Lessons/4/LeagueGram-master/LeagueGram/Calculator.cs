using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeagueGram
{
    class Calculator
    {
        public Func<int, int, int> Calculating(char operation)
        {
            switch (operation)
            {
                case '+':
                    return (a,b) => a+b;
                case '-':
                    return (a, b) => a - b;
                case '*':
                    return (a, b) => a * b;
                case '/':
                    return (a, b) => a / b;
                default:
                    return null;

            }

            Action<string> writeLine = b => Console.WriteLine(b);
        }

        
    }
}

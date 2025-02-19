using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Customer
    {
        public string? GreetMessage;
        public string GreetAndCombine(string firstName, string lastName)
        {
            GreetMessage = $"Hello, {firstName} {lastName}";
            return GreetMessage;
        }   
    }
}

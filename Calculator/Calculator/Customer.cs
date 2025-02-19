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

        public int Discount { get; set; } = 20;
        public string GreetAndCombine(string firstName, string lastName)
        {

            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("First Name cannot be empty");
            }
            GreetMessage = $"Hello, {firstName} {lastName}";
            Discount = 30;
            return GreetMessage;
        }   
    }
}

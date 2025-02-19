using Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class CustomerTest
    {
        public Customer customer;

        [SetUp]
        public void setup()
        {
            customer = new Customer();
        }

        [Test]
        public void GreetAndCombine_InputTwoStrings_ReturnCombinedString()
        {
            customer.GreetAndCombine("John", "Doe");
            Assert.That(customer.GreetMessage, Does.Contain(","));
            Assert.That(customer.GreetMessage, Does.Contain("john Doe").IgnoreCase);
            Assert.That(customer.GreetMessage, Does.StartWith("Hello"));
            Assert.That(customer.GreetMessage, Is.EqualTo("Hello, John Doe"));
            //Assert.That(result,Does.Match("Hello","regular expression")); 

        }

        [Test]  
        public void Customer_GreetMessageIsNull()
        {
            Assert.That(customer.GreetMessage, Is.Null);
        }

    }
}

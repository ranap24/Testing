using Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    public class CustomerTest
    {
        private Customer customer = null!;

        [SetUp]
        public void setup()
        {
            customer = new Customer();
        }

        [Test]
        public void GreetAndCombine_InputTwoStrings_ReturnCombinedString()
        {
            customer.GreetAndCombine("John", "Doe");

            //to run multiple assertions
            Assert.Multiple(() =>
            {
                Assert.That(customer.GreetMessage, Does.Contain(","));
                Assert.That(customer.GreetMessage, Does.Contain("john Doe").IgnoreCase);
                Assert.That(customer.GreetMessage, Does.StartWith("Hello"));
                Assert.That(customer.GreetMessage, Is.EqualTo("Hello, John Doe"));
            });
            //Assert.That(result,Does.Match("Hello","regular expression")); 

        }

        [Test]  
        public void Customer_GreetMessageIsNull()
        {
            Assert.That(customer.GreetMessage, Is.Null);
        }

        [Test]
        
        public void Customer_DiscountBumpTo30()
        {
            customer.GreetAndCombine("John", "Doe");
            Assert.That(customer.Discount, Is.EqualTo(30));
        }

        [Test]
        public void Customer_Discount_IsInRange()
        {
            customer.GreetAndCombine("John", "Doe");

            //use of Is.InRange Helper method
            Assert.That(customer.Discount, Is.InRange(20, 30));
        }

        [Test]
        public void CustomerGreeting_EmptyFirstName_ThrowsException()
        {
            var ex = Assert.Throws<ArgumentException>(() => customer.GreetAndCombine("", "Doe"));
            //testing the exception
            Assert.That(ex.Message, Is.EqualTo("First Name cannot be empty"));

            //alternate way of tesing the exception
            Assert.That(() => customer.GreetAndCombine("", "Doe"), Throws.ArgumentException.With.Message.EqualTo("First Name cannot be empty"));

            //testing the exception with only its type

            Assert.That(() => customer.GreetAndCombine("", "Doe"), Throws.ArgumentException);

            //alternate way of testing the exception with only its type
            Assert.Throws<ArgumentException>(() => customer.GreetAndCombine("", "Doe"));    
        }

    }
}

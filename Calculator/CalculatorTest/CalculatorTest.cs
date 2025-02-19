using NUnit.Framework;
using Calculator;
using NUnit.Framework.Legacy;

namespace CalculatorTest
{
    [TestFixture]
    public class CalculatorTest
    {
        private CalculatorForTest calculator = null!;

        [SetUp]
        public void Setup()
        {
            calculator = new CalculatorForTest();
        }

        [TestCase(2, 4, ExpectedResult = 6)]
        public int AddNumbers_InputTwoInt_ReturnSum(int a, int b)
        {
            return calculator.add(a, b);
        }

        [TestCase(2.5, 4.5, ExpectedResult = 7.0)]
        [TestCase(2.0, 5.0, ExpectedResult = 7.0)]
        public double AddNumbers_InputTwoDouble_ReturnSum(double a, double b)
        {
            return calculator.addDobule(a, b);
        }

        [Test]
        public void OddNumbers_InputMinMaxRange_ReturnsOddNumbersInRange()
        {
            List<int> expectedNumbers = new() { 1, 3, 5, 7, 9 };
            var result = calculator.OddNumbers(1, 10);
            Assert.That(result, Is.EquivalentTo(expectedNumbers));
        }
    }
}

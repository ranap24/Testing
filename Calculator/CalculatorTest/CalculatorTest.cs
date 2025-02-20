using NUnit.Framework;
using Calculator;

namespace CalculatorTest
{
    /// <summary>
    /// Unit tests for the CalculatorForTest class.
    /// </summary>
    [TestFixture]
    public class CalculatorTest
    {
        private CalculatorForTest calculator = null!;

        /// <summary>
        /// Sets up the test environment by initializing the CalculatorForTest instance.
        /// </summary>
        [SetUp]
        public void Setup()
        {
            calculator = new CalculatorForTest();
        }

        /// <summary>
        /// Tests the addition of two integers.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>The sum of the two integers.</returns>
        [TestCase(2, 4, ExpectedResult = 6)]
        public int AddNumbers_InputTwoInt_ReturnSum(int a, int b)
        {
            return calculator.add(a, b);
        }

        /// <summary>
        /// Tests the addition of two double values.
        /// </summary>
        /// <param name="a">The first double value.</param>
        /// <param name="b">The second double value.</param>
        /// <returns>The sum of the two double values.</returns>
        [TestCase(2.5, 4.5, ExpectedResult = 7.0)]
        [TestCase(2.0, 5.0, ExpectedResult = 7.0)]
        public double AddNumbers_InputTwoDouble_ReturnSum(double a, double b)
        {
            return calculator.addDobule(a, b);
        }

        /// <summary>
        /// Tests the retrieval of odd numbers within a specified range.
        /// </summary>
        [Test]
        public void OddNumbers_InputMinMaxRange_ReturnsOddNumbersInRange()
        {
            List<int> expectedNumbers = new() { 1, 3, 5, 7, 9 };
            var result = calculator.OddNumbers(5, 10);
            Assert.That(result, Is.EquivalentTo(expectedNumbers));
        }
    }
}

using NUnit.Framework;
using Calculator;

namespace CalculatorTest
{
    [TestFixture]
    public class GradeCalculatorTest
    {
        private GradeCalculator gradeCalculator = null!;

        [SetUp]
        public void Setup()
        {
            gradeCalculator = new GradeCalculator();
        }

        [TestCase(95, ExpectedResult = "A+")]
        [TestCase(90, ExpectedResult = "A+")]
        [TestCase(89, ExpectedResult = "A")]
        [TestCase(80, ExpectedResult = "A")]
        [TestCase(79, ExpectedResult = "B")]
        [TestCase(70, ExpectedResult = "B")]
        [TestCase(69, ExpectedResult = "C")]
        [TestCase(60, ExpectedResult = "C")]
        [TestCase(59, ExpectedResult = "D")]
        [TestCase(50, ExpectedResult = "D")]
        [TestCase(49, ExpectedResult = "F")]
        [TestCase(0, ExpectedResult = "F")]
        public string GetGradeWithPercentage_InputPercentage_ReturnsExpectedGrade(int percentage)
        {
            return gradeCalculator.GetGradeWithPercentage(percentage);
        }
    }
}


namespace NUnit_Practice.Tests
{
    public class GradeCalulatorTests
    {
        private GradeCalculator _gradeCalculator { get; set; } = null!;   
        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [TestCase(99)]
        [TestCase(95)]
        [TestCase(91)]
        public void GetGradeByPercentage_EqualTest(int percentage)
        {
            //Assign
            //var percentage = 92;

           //Act
           var grade = _gradeCalculator.GetGradeByPercentage(percentage);   
            //Assert

            Assert.That(grade, Is.EqualTo("A"));
        }

        [TestCase(1)]
        [TestCase(20)]
        [TestCase(45)]
        [TestCase(65)]
        [TestCase(80)]

        public void GetGradeByPercentage_NotEqualTest(int percentage)
        {
            //Assign
            //var percentage = 92;

            //Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);
            //Assert

            Assert.That(grade, Is.Not.EqualTo("A"));
        }   
    }
}
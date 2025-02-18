
namespace NUnit_Practice
{
    public class GradeCalculator
    {

        public string GetGradeByPercentage(int percentage)
        {
            if (percentage < 0)
                return "invalid";
            else if (percentage > 90)
            {
                return "A";
            }
            else if(percentage >=75 && percentage < 90)
            {
                return "B";
            }
            else if(percentage >= 60 && percentage < 75)
            {
                return "C";
            }
            else if (percentage >= 50 && percentage < 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }   
        }
    }
}

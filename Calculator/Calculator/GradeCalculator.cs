using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class GradeCalculator
    {
        public string GetGradeWithPercentage(int percentage)
        {
            if (percentage >= 90)
            {
                return "A+";
            }
            else if (percentage >= 80)
            {
                return "A";
            }
            else if (percentage >= 70)
            {
                return "B";
            }
            else if (percentage >= 60)
            {
                return "C";
            }
            else if (percentage >= 50)
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

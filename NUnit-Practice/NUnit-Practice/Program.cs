using NUnit_Practice;

var gradeCalculator = new GradeCalculator();
Console.WriteLine("Enter the Percentage: ");
var percentage = Convert.ToInt32(Console.ReadLine());
var grade = gradeCalculator.GetGradeByPercentage(percentage);
Console.WriteLine(grade); // Output: B


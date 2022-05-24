using System;

namespace UnitTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            var gradeCalculator = new GradeCalculator();

            Console.WriteLine("Insert the percentage: ");
            
            var percentage = Convert.ToDouble(Console.ReadLine());

            var grade = gradeCalculator.GetGradeByPercentage(percentage);

            System.Console.WriteLine($"The grade is: {grade}");
        }
    }
}

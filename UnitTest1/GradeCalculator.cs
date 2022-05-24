using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest1
{
    public class GradeCalculator
    {
        /*
        Grades:
            A: 90 - 100
            B: 80 - 89
            C: 70 - 79
            D: 60 - 69
            F: 0 - 59
        */
        public string GetGradeByPercentage(double percentage)
        {
            if(percentage >= 90 && percentage <= 100)
                return "A";
            else if(percentage >= 80 && percentage <= 89)
                return "B";
            else if(percentage >= 70 && percentage <= 79)
                return "C";
            else if(percentage >= 60 && percentage <= 69)
                return "D";
            else if(percentage >= 0 && percentage <= 59)
                return "F";
            else
                return "Invalid";
        }
    }
}

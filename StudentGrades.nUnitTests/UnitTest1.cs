using NUnit.Framework;
using UnitTest1;

namespace StudentGrades.nUnitTests
{
    public class Tests
    {
        private GradeCalculator Grades { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            Grades = new GradeCalculator();
        }

        // Equal tests
        [TestCase(0, "F")]
        [TestCase(59, "F")]
        [TestCase(61, "D")]
        [TestCase(70, "C")]
        [TestCase(80, "B")]
        [TestCase(90, "A")]
        [TestCase(91, "A")]
        [TestCase(100, "A")]
        public void GetGradeByPercentage_EqualTest(int percentage, string expectedGrade )
        {
            Assert.AreEqual(expectedGrade, Grades.GetGradeByPercentage(percentage));
        }

        // Not Equal tests
        [TestCase(100, "F")]
        [TestCase(90, "D")]
        [TestCase(80, "C")]
        [TestCase(70, "B")]
        [TestCase(60, "A")]
        [TestCase(59, "A")]
        [TestCase(0, "A")]
        public void GetGradeByPercentage_NotEqualTest(int percentage, string expectedGrade)
        {
            Assert.AreNotEqual(expectedGrade, Grades.GetGradeByPercentage(percentage));
        }
    }
}
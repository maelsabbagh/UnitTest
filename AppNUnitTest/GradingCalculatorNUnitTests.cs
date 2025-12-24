using App;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNUnitTest
{
    [TestFixture]
    public class GradingCalculatorNUnitTests
    {
        private GradingCalculator gradingCalculator;
        [SetUp]
        public void setup()
        {
            gradingCalculator = new GradingCalculator();
        }

        [Test]
        public void GradingCalculator_InputScoreAndAttendance_OutputA()
        {
            // Arrange
            gradingCalculator.Score = 95;
            gradingCalculator.AttendancePercentage = 90;

            //Act
            string result = gradingCalculator.GetGrade();

            //Assert
            ClassicAssert.AreEqual("A", result);
        }
        [Test]
        [TestCase(85,90, ExpectedResult = "B")]
        [TestCase(95, 65, ExpectedResult = "B")]
        [TestCase(65,90,ExpectedResult ="C")]
        
        public string GradingCalculator_InputScoreAndAttendance(int score,int attendancePercentage)
        {
            // Arrange
            gradingCalculator.Score = score;
            gradingCalculator.AttendancePercentage = attendancePercentage;

            //Act
            string result = gradingCalculator.GetGrade();
            //Assert

            return result;
        }

        [Test]
        [TestCase(95, 55)]
        [TestCase(65, 55)]
        [TestCase(50, 90)]

        public void GradingCalculator_InputScoreAndAttendance_OutputF(int score, int attendancePercentage)
        {
            // Arrange
            gradingCalculator.Score = score;
            gradingCalculator.AttendancePercentage = attendancePercentage;

            //Act
            string result = gradingCalculator.GetGrade();


            // Assert
            ClassicAssert.AreEqual("F", result);
        }
    }
}

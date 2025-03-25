using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.InterviewPrep.OneWeek;
using Microsoft.VisualBasic;

namespace HackerRank.Test.InterviewPrep.OneWeek
{
    [TestClass]
    public class DayOneTests
    {
        private StringWriter _writer = new StringWriter();
        private StringWriter _expectedOutput = new StringWriter();

        public DayOneTests()
        {
            Console.SetOut(_writer);
        }

        [TestMethod]
        public void PlusMinus_WhenGivenArrayOfIntegers_PrintsOutRatioPositiveNegativeZero()
        {
            //Arrange
            List<int> test = new List<int> { -4, 3, -9, 0, 4, 1 };
            
            _expectedOutput.WriteLine("0.500000");
            _expectedOutput.WriteLine("0.333333");
            _expectedOutput.WriteLine("0.166667");

            //Act
            DayOne.PlusMinus(test);

            //Assert
            Assert.IsTrue(String.Equals(_writer.ToString(), _expectedOutput.ToString()));

        }

        [TestMethod]
        public void MiniMaxSum_GivenFivePositiveIntegers_PrintsOutMinimumAndMaximumSumFromFourIntegers()
        {
            // Arrange
            List<int> arr = new List<int> { 7, 69, 2, 221, 8974 };
            _expectedOutput.WriteLine("299 9271");
            
            // Act 
            DayOne.MiniMaxSum(arr);

            // Assert
            Assert.IsTrue(String.Equals(_writer.ToString(), _expectedOutput.ToString()));
        }

        [TestMethod]
        public void TimeConversion_GivenTwelveHourAMPMTime_PrintsMilitaryTwentyFourHour()
        {
            // Arrange
            string timeCaseA = "12:05:45PM";
            string timeCaseAexpectedOutput = "12:05:45";

            string timeCaseB = "12:05:45AM";
            string timeCaseBexpectedOutput = "00:05:45";

            string timeCaseC = "05:05:45PM";
            string timeCaseCexpectedOutput = "17:05:45";

            // Act 
            string timeCaseAConversion = DayOne.TimeConversion(timeCaseA);
            string timeCaseBConversion = DayOne.TimeConversion(timeCaseB);
            string timeCaseCConversion = DayOne.TimeConversion(timeCaseC);


            // Assert
            Assert.IsTrue(String.Equals(timeCaseAConversion, timeCaseAexpectedOutput));
            Assert.IsTrue(String.Equals(timeCaseBConversion, timeCaseBexpectedOutput));
            Assert.IsTrue(String.Equals(timeCaseCConversion, timeCaseCexpectedOutput));

        }

        [TestMethod]
        // Day One Test
        // https://www.hackerrank.com/test/eoipgdk427n/questions/a8taf02a12a
        public void FindMedian_WhenGivenOddNumbers_ReturnMedian()
        {
            // Arrange 
            List<int> arr = new List<int> { 1, 2, 12, 9, 4};
            int expectedOutput = 4;

            // Act
            var median = DayOne.FindMedian(arr);

            // Assert
            Assert.AreEqual(expectedOutput, median);
        }
    }
}

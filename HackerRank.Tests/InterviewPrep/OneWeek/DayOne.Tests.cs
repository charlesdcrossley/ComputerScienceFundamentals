using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.InterviewPrep.OneWeek;

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
            DayOne.plusMinus(test);

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
            DayOne.miniMaxSum(arr);

            // Assert
            Assert.IsTrue(String.Equals(_writer.ToString(), _expectedOutput.ToString()));
        }
    }
}

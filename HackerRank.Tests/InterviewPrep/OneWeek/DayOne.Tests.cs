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
        [TestMethod]
        public void PlusMinus_WhenGivenArrayOfIntegers_ReturnsRatioPositiveNegativeZero()
        {
            //Arrange
            List<int> test = new List<int> { -4, 3, -9, 0, 4, 1 };

            var writer = new StringWriter();
            Console.SetOut(writer);

            var expectedOutput = new StringWriter();
            expectedOutput.WriteLine("0.500000");
            expectedOutput.WriteLine("0.333333");
            expectedOutput.WriteLine("0.166667");

            //Act
            DayOne.plusMinus(test);

            //Assert
            Assert.IsTrue(String.Equals(writer.ToString(), expectedOutput.ToString()));

        }

    }
}

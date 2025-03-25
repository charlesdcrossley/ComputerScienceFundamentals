using HackerRank.InterviewPrep.OneWeek;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Test.InterviewPrep.OneWeek
{
    [TestClass]
    public class DayTwoTests
    {
        private StringWriter _writer = new StringWriter();

        public DayTwoTests()
        {
            Console.SetOut(_writer);
        }
        [TestMethod]
        public void LonelyInteger_GivenArrayOfIntegers_FindUniqueInteger()
        {
            // Arrange
            List<int> a = new List<int> { 1, 2, 3, 4, 3, 2, 1 };
            int expectedOutput = 4;

            // Act 
            int result = DayTwo.Lonelyinteger(a);

            // Assert
            Assert.AreEqual(expectedOutput, result);
        }
        [TestMethod]
        public void DiagonalDifference_GivenSquareMatrix_FindUniqueInteger()
        {
            // Arrange
            List<List<int>> arr = [ [1,2,3],
                                    [4,5,6],
                                    [9,8,9]];

            int expectedResult = 2;

            // Act
            int result = DayTwo.DiagonalDifference(arr);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}

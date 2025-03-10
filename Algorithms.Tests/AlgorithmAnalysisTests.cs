using Algorithms.AlgorithmAnalysis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test
{
    [TestClass]
    public class AlgorithmAnalysisTests
    {
        [TestMethod]
        public void ThreeSum_WhenGivenAnArrayOfIntegers_ReturnsCountOfTriplets()
        {
            int[] integers = FileReader.ReadIntegersFromFile(@"TestData\1Kints.txt").ToArray();
            int expectedResult = 70;

            Assert.AreEqual(expectedResult, ThreeSum.EqualZeroCountCubicComplexity(integers));

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.HackerRankProblems.Arrays;

namespace Algorithms.Tests.HackerRankTests
{
    [TestClass]
    public class TwoDArrayDSTests
    {
        [TestMethod]
        public void HourGlassSum_Whengiven2DArrayOfIntegers_ReturnsMaximumHourGlassSum()
        {
            List<List<int>> intervals = [   [1, 1, 1, 0, 0, 0], 
                                    [0, 1, 0, 0, 0, 0], 
                                    [1, 1, 1, 0, 0, 0], 
                                    [0, 0, 2, 4, 4, 0],
                                    [0, 0, 0, 2, 0, 0],
                                    [0, 0, 1, 2, 4, 0]

                                ];

            int expectedResult = 19;

            var output = TwoDArrayDS.HourglassSum(intervals);

            Assert.AreEqual(expectedResult, output);

        }

    }
}

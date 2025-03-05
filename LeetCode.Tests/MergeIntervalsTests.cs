using Practice.LeetCode.AmazonInterviewQuestions;

namespace Algorithms.Tests.LeetCodeTests
{
    [TestClass]
    public class MergeIntervalsTests
    {
        [TestMethod]
        public void MergeInvervals_WhengivenArrayOfIntervals_ReturnsMergeOfOverlapping()
        {
            int[][] intervals = [[1, 3], [2, 6], [8, 10], [15, 18]];
            int[][] expectedResult = [[1, 6], [8, 10], [15, 18]];

            var output = MergeIntervals.Merge(intervals);

            CollectionAssert.AreEqual(expectedResult, output);

        }

    }
}

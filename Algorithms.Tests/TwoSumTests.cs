using Algorithms.LeetCodeProblems.AmazonInverviewQuestions.TwoSum;
using System.Runtime.CompilerServices;

namespace Algorithms.Tests
{
    [TestClass]
    public sealed class TwoSumTests
    {
        [TestMethod]
        public void TwoSumQuadraticComplexity_WhenGivenArrayOfIntegersAndTarget_ReturnsIndeciesOfNumbersTotallingTarget()
        {
            int[] nums = [2, 7, 11, 15];
            int target = 9;
            int[] expectedOutput = [0, 1];

            var output = TwoSum.TwoSumQuadraticComplexity(nums, target);

            CollectionAssert.AreEqual(output,expectedOutput);
        }
        [TestMethod]
        public void TwoSumLinearComplexity_WhenGivenArrayOfIntegersAndTarget_ReturnsIndeciesOfNumbersTotallingTarget()
        {
            int[] nums = [2, 7, 11, 15];
            int target = 9;
            int[] expectedOutput = [0, 1];

            var output = TwoSum.TwoSumLinearComplexity(nums, target);

            CollectionAssert.AreEqual(output, expectedOutput);
        }

    }
}

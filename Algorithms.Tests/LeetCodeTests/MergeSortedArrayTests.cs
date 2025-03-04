using Algorithms.LeetCodeProblems.AmazonInverviewQuestions;

namespace Algorithms.Tests.LeetCodeTests
{
    [TestClass]
    public class MergeSortedArrayTests
    {
        [TestMethod]
        public void MergeSortedArray_WhenGivenTwoIntegerArraysInNonDecreasingOrder_Nums1ReplacedWithMergedArrayInNonDecreasingOrder()
        {
            int[] nums1 = [1, 2, 3, 0, 0, 0];
            int m = 3;
            int[] nums2 = [2, 5, 6];
            int n = 3;

            int[] expectedOutput = [1, 2, 2, 3, 5, 6];

            MergeSortedArray.Merge(nums1, m, nums2, n);

            Assert.AreEqual(m, n);
        }

        [TestMethod]
        public void MergeSortedArray_WhenGivenAnEmptyNums2_Nums1IsReturned()
        {
            int[] nums1 = [1];
            int m = 1;
            int[] nums2 = [];
            int n = 0;

            int[] expectedOutput = [1];

            MergeSortedArray.Merge(nums1, m, nums2, n);

            CollectionAssert.AreEqual(expectedOutput, nums1);
        }


    }
}

using Algorithms.Sorting.BubbleSort;
using Algorithms.Sorting.MergeSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.Sorting
{
    [TestClass]
    public class MergeSortTests
    {
        [TestMethod]
        public void Sort_WhenGivenArrayOfIntegers_ReturnsSortedArray()
        {
            // Arrange
            int[] unsortedArray = new int[8] { 50, 35, -30, 150, 80, -10, -45, 142 };
            int[] expectedResult = unsortedArray.Order().ToArray();

            // Act 
            int[] sortedArray = MergeSort.Sort(unsortedArray);

            // Assert
            CollectionAssert.Equals(sortedArray, expectedResult);

        }

    }
}

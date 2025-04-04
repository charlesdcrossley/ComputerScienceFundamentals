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
            int[] array = new int[8] { 50, 35, -30, 150, 80, -10, -45, 142 };
            int[] expectedResult = new int[8] { -45, -30, -10, 35, 50, 80, 142, 150 };

            // Act 
            MergeSort.Sort(array);

            // Assert
            Assert.IsTrue(IsSorted(array));

        }
        private bool IsSorted(int[] array)
        {
            for(int i = 1; i< array.Length; i++)
            {
                if (array[i - 1] > array[i])
                    return false;

            }
            return true;
        }

    }
}

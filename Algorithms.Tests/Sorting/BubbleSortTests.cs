using Algorithms.Sorting.BubbleSort;
using Algorithms.Sorting.InsertionSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.Sorting
{
    [TestClass]
    public class BubbleSortTests
    {
        [TestMethod]
        public void Sort_WhenGivenArrayOfIntegers_ReturnsSortedArray()
        {
            // Arrange
            int[] unsortedArray = new int[8] { 50, 35, -30, 150, 80, -10, -45, 142};
            int[] expectedResult = new int[8] { -45, -30, -10, 35, 50, 80, 142, 150};

            // Act 
            int[] sortedArray = BubbleSort.Sort(unsortedArray);

            // Assert
            CollectionAssert.Equals(sortedArray, unsortedArray.Order());

        }
    }
}

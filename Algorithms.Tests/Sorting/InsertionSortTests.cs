using Algorithms.Sorting.InsertionSort;
using Algorithms.Sorting.SelectionSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test.Sorting
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void Sort_WhenGivenArrayOfIntegers_ReturnsSortedArray()
        {
            // Arrange
            int[] unsortedArray = new int[10] { 4, 6, 1, 3, 2, 9, 7, 5, 8, 10 };
            int[] expectedResult = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act 
            int[] sortedArray = InsertionSort.Sort(unsortedArray);

            // Assert
            CollectionAssert.Equals(sortedArray, expectedResult);

        }
    }
}

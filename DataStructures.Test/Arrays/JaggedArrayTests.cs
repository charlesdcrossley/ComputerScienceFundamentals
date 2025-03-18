using DataStructures.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Test.Arrays
{
    [TestClass]
    public class JaggedArrayTests
    {
        [TestMethod]
        public void CreateInstance_WhenInstantiated_ReturnsEmptyJaggedArray()
        {
            // Arrange
            int expectedIndexes = 7;
            

            // Act
            JaggedArray<int> twoDimArray = new JaggedArray<int>(7);

            // Assert
            // 7
            Assert.AreEqual(twoDimArray.GetArray().Length, expectedIndexes );
        }
        [TestMethod]
        public void AddArrayByIndex_WhenCalled_AddsArrayToIndex()
        {
            // Arrange 
            JaggedArray<int> testArray = new JaggedArray<int>(3);

            // Act 
            testArray.AddArray(0, [1, 2, 3, 4]);
            testArray.AddArray(2, [4, 3, 2]);
            testArray.AddArray(1, [7]);

            // Assert
            Assert.AreEqual(testArray.GetArray()[0][2], 3);
            Assert.AreEqual(testArray.GetArray(2)[2], 2);
        }
        [TestMethod]
        public void AddFullJaggedArray_WhenCalled_AddsJaggedArray()
        {
            // Arrange 
            int[][] inputArray =
            {
               new int[] {1,2,3,4},
               [6,5,3,4],
               null
            };

            JaggedArray<int> testArray = new JaggedArray<int>(3);

            // Act 
            testArray.AddArray(inputArray);            

            // Assert
            Assert.AreEqual(testArray.GetArray()[0][2], 3);
            Assert.AreEqual(testArray.GetArray(2), null);
        }

        [TestMethod]
        public void GetValue_WhenGivenArrayAndValueIndex_ReturnsStoredValue()
        {
            // Arrange
            JaggedArray<int> testArray = new JaggedArray<int>(3);
            int expectedValue = 7;

            // Act
            testArray.AddArray(0, [1, 2, 3, 4]);
            testArray.AddArray(2, [4, 3, 2]);
            testArray.AddArray(1, [7]);

            // Assert
            Assert.AreEqual(testArray.GetValue(2, 0), 4);
            
        }

        [TestMethod]
        public void Find_WhenGivenValueToFind_ReturnsIndex()
        {
            // Arrange
            JaggedArray<int> jaggedArray = new JaggedArray<int>(5);
            int[] expectedResult = [3,3];

            jaggedArray.AddArray(0, [1, 2, 3, 4]);
            jaggedArray.AddArray(2, [4, 3, 2]);
            jaggedArray.AddArray(1, [7]);
            jaggedArray.AddArray(3, [5, 8, 7, 6]);
            jaggedArray.AddArray(4, [2, 3, 4, 5]);

            // Act 
            int[] result = jaggedArray.Find(6);

            //Assert
            CollectionAssert.AreEqual(result, expectedResult);
        }
    }
}

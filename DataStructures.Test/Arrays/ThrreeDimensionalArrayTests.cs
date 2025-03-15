using DataStructures.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Test.Arrays
{
    [TestClass]
    public class ThrreeDimensionalArrayTests
    {
        [TestMethod]
        public void CreateInstance_WhenInstantiated_ReturnsEmptyArrayOfSize()
        {
            // Arrange 

            int expectedRows = 3;
            int expectedColumns = 4;
            int expectedLevels = 5;

            // Act 

            ThreeDimensionalArray<int> testArray = new ThreeDimensionalArray<int>(3, 4, 5);

            // Assert

            Assert.AreEqual(testArray.GetArray().Length, expectedRows * expectedColumns * expectedLevels);

        }
        [TestMethod]
        public void GetLength_WhenInstantiated_ReturnsLength()
        {
            // Arrange
            int expectedLength = 3;

            // Act
            ThreeDimensionalArray<bool> testArray = new ThreeDimensionalArray<bool>(3, 4, 5);

            // Assert
            Assert.AreEqual(testArray.GetLength(), expectedLength);
        }
        [TestMethod]
        public void GetWidth_WhenInstantiated_ReturnsHeight()
        {
            // Arrange
            int expectedWidth = 4;

            // Act
            ThreeDimensionalArray<bool> testArray = new ThreeDimensionalArray<bool>(3, 4, 5);

            // Assert
            Assert.AreEqual(testArray.GetWidth(), expectedWidth);
        }
        [TestMethod]
        public void GetHeight_WhenInstantiated_ReturnsHeight()
        {
            // Arrange
            int expectedHeight = 5;

            // Act 
            ThreeDimensionalArray<char> testArray = new ThreeDimensionalArray<char>(3,4,5);

            // Assert
            Assert.AreEqual(expectedHeight, testArray.GetHeight());
        }

        [TestMethod]
        public void PopulateArray_WhenGivenListOfListsOfLists_Populates3DimensionalArray()
        {
            // Arrange
            ThreeDimensionalArray<int> testArray = new ThreeDimensionalArray<int>(5, 5, 5);

            List<List<List<int>>> fullCube = new List<List<List<int>>>();
            List<List<int>> slicesOfCube = new List<List<int>>();

            for(int i = 0; i< 5; i++)
            {
                slicesOfCube.Add(new List<int>() { i, i + 1, i + 2, i + 3, i + 4 });
            }

            for (int i = 0; i < 5; i++)
            {
                fullCube.Add(slicesOfCube);
            }

            // Act 
            testArray.PopulateArray(fullCube);

            //Assert            

            CollectionAssert.AllItemsAreInstancesOfType(testArray.GetArray(), typeof(int));
            Assert.AreEqual(testArray.GetArray()[0, 0,0], 0);
            Assert.AreEqual(testArray.GetArray()[4, 4, 4], 8);
        }
    }
}

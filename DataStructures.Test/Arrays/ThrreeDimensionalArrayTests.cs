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

            List<List<List<int>>> fullCube = PopulateTestArrayOfIntegers(5, 5, 5);
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

        [TestMethod]
        public void Find_WhenGivenValue_ReturnsIndexes()
        {
            // Arrange
            ThreeDimensionalArray<int> testArray = new ThreeDimensionalArray<int>(3, 4, 5);

            List<List<List<int>>> dataToPopulate = PopulateTestArrayOfIntegers(3, 4, 5);
            testArray.PopulateArray(dataToPopulate);

            int[] expectedResult = [0,1,4 ];
            // Act 

            int[] resultIndex = testArray.Find(5);

            // Assert

            CollectionAssert.AreEqual(resultIndex, expectedResult);
        }
        private List<List<List<int>>> PopulateTestArrayOfIntegers(int length, int width, int height)
        {
            List<List<List<int>>> fullCube = new List<List<List<int>>>();

            for (int i = 0; i < length; i++)
            {
                List<List<int>> slicesOfCube = new List<List<int>>();

                for(int j=0; j<width; j++)
                {
                    List<int> slicesOfPlane = new List<int>(); 
                    for(int k=0; k<height; k++)
                    {
                        slicesOfPlane.Add(i+j+k);
                    }
                    slicesOfCube.Add(slicesOfPlane);
                }
                fullCube.Add(slicesOfCube);
            }
            
            return fullCube;
        }
        [TestMethod]
        public void GetValue_WhenGiveLengthWidthHeight_ReturnsValueFromCube()
        {
            // Arrange
            ThreeDimensionalArray<int> testArray = new ThreeDimensionalArray<int>(10, 10, 10);

            List<List<List<int>>> dataToPopulate = PopulateTestArrayOfIntegers(10, 10, 10);
            testArray.PopulateArray(dataToPopulate);

            int length = 5;
            int width = 5;
            int height = 5;

            int value = testArray.GetValue(length, width, height);
            Assert.AreEqual(15, value);

        }
    }
}

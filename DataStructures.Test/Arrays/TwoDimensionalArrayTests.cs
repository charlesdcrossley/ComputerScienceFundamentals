using System;
using System.Collections.Generic;
using System.Linq;
using Bogus;
using DataStructures.Arrays;
using Newtonsoft.Json.Bson;

namespace DataStructures.Test.Arrays
{
    [TestClass]
    public class TwoDimensionalArrayTests
    {
        private Faker _faker = new Faker();

        [TestMethod]
        public void CreateInstance_WhenInstantiated_CreatesEmptyTwoDArray()
        {
            // Arrange
            int expectedColumns = 7;
            int expectedRows = 7;
            
            // Act
            TwoDimensionalArray<int> twoDimArray = new TwoDimensionalArray<int>(7, 7);
            
            // Assert
            // 49
            Assert.AreEqual(twoDimArray.GetArray().Length,expectedRows * expectedColumns);
            
        }
        [TestMethod]
        public void GetColumnSize_WhenCalled_ReturnsColumnSize()
        {
            // Arrange
            TwoDimensionalArray<float> testArray = new TwoDimensionalArray<float>(5,5);
            int expectedColumnSize = 5;
            // Act
            int columnSize = testArray.GetColumnSize();

            // Assert
            Assert.AreEqual(columnSize, expectedColumnSize);            
        }
        [TestMethod]
        public void GetRowSize_WhenCalled_ReturnsColumnSize()
        {
            // Arrange 
            TwoDimensionalArray<bool> testArray = new TwoDimensionalArray<bool>(4, 30);
            int expectedRowSize = 4;
            
            // Act 
            int rowSize = testArray.GetRowSize();

            // Assert
            Assert.AreEqual(rowSize, expectedRowSize);
        }
        [TestMethod]
        public void PopulateArray_WhenGivenListOfLists_Populates2DimArray()
        {
            // Arrange
            TwoDimensionalArray<int> testArray = new TwoDimensionalArray<int>(5,5);

            List<List<int>> dataToPopulate = new List<List<int>>();

            for(int i = 0; i< 5; i++)
            {
                dataToPopulate.Add(new List<int>() { i,i+1,i+2,i+3,i+4});
            }            

            // Act 
            testArray.PopulateArray(dataToPopulate);

            //Assert            

            CollectionAssert.AllItemsAreInstancesOfType(testArray.GetArray(), typeof(int));
            Assert.AreEqual(testArray.GetArray()[1, 3], 4);
            Assert.AreEqual(testArray.GetArray()[4, 4], 8);
        }

        [TestMethod]
        public void GetValue_WhenGiveColumnAndRow_ReturnsValue()
        {
            // Arrange
            TwoDimensionalArray<int> testArray = new TwoDimensionalArray<int>(10, 10);
            int column = 5;
            int row = 5;

            int value = testArray.GetValue(row, column);

        }
        [TestMethod]
        public void Find_WhenGivenValue_ReturnsIndexes()
        {
            // Arrange
            TwoDimensionalArray<int> testArray = new TwoDimensionalArray<int>(3, 3);

            List<List<int>> dataToPopulate = PopulateTestArrayOfIntegers(3,3);
            testArray.PopulateArray(dataToPopulate);

            int[] expectedResult = [2, 2];
            // Act 

            int[] resultIndex = testArray.Find(5);

            // Assert

            CollectionAssert.AreEqual(resultIndex, expectedResult);
        }

        private List<List<int>> PopulateTestArrayOfIntegers(int rowSize, int columnSize)
        {   
            List<List<int>> dataToPopulate = new List<List<int>>();

            for (int i = 0; i < rowSize; i++)
            {           
                dataToPopulate.Add(Enumerable.Range(1, columnSize).Select(x => x + i).ToList());
            }
            return dataToPopulate;
        }
    }
}

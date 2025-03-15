using Bogus;
using DataStructures.Arrays;
using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using System;
using System.Collections.Generic;

namespace DataStructures.Test.Arrays
{
    [TestClass]
    public class SingleDimensionalArrayTests 
    {
        private Faker _faker = new Faker();

        [TestMethod]
        public void CreateInstance_WhenInstantiated_ReturnsEmptyArrayOfSize()
        {
            // Arrange 

            int arraySize = 40;

            // Act 
            SingleDimensionArray<string> emptyArray = new SingleDimensionArray<string>(arraySize);

            // Assert 

            Assert.AreEqual(arraySize, emptyArray.GetArray().Length);

        }

        [TestMethod]
        public void PopulateEmptyArray_WhenGivenEmptyArrayAndListOfElements_ReturnsPopulatedArray()
        {
            // Arrange
            SingleDimensionArray<string> emptyArray = new SingleDimensionArray<string>(40);

            var randomStrings = Enumerable.Range(1, 40).Select(f => _faker.Random.AlphaNumeric(10)).ToList();

            // Act 
            var populatedArray = SingleDimensionArray<string>.PopulateEmptyArray(emptyArray.GetArray(), randomStrings);

            // Assert 
            CollectionAssert.AllItemsAreNotNull(populatedArray);
        }

        [TestMethod]
        public void GetFirstElement_WhenGivenAPopulatedArray_ReturnFirstElement()
        {
            // Arrange
            int[] populatedArray = Enumerable.Range(1, 10).Select(f => _faker.Random.Int()).ToArray();
            var expectedResult = populatedArray.GetValue(0);

            // Act
            int firstElement = SingleDimensionArray<int>.GetFirstElement(populatedArray);

            // Assert
            Assert.AreEqual(firstElement, expectedResult);
        }
        [TestMethod]
        public void GetLastElement_WhenGivenAPopulatedArray_ReturnsLastElement()
        {
            // Arrange
            int[] populatedArray = Enumerable.Range(1, 10).Select(f => _faker.Random.Int()).ToArray();
            var expectedResult = populatedArray.GetValue(9);

            // Act
            int lastElement = SingleDimensionArray<int>.GetLastElement(populatedArray);

            // Assert
            Assert.AreEqual(lastElement, expectedResult);
        }
        [TestMethod]
        public void GetNthElement_WhenGivenPopulatedArray_ReturnsNthElement()
        {
            // Arrange
            int[] populatedArray = Enumerable.Range(1, 10).Select(f => _faker.Random.Int()).ToArray();
            var expectedResult = populatedArray.GetValue(4);

            // Act
            int nthElement = SingleDimensionArray<int>.GetNthElement(populatedArray, 4);

            // Assert
            Assert.AreEqual(nthElement, expectedResult);

        }
        [TestMethod]
        public void FindValue_WhenGivenArrayAndValue_ReturnsIndex()
        {
            // Arrange
            int[] populatedArray = [1, 2, 3, 4, 5, 6, 6, 8, 9, 10];

            // Act

            int index = SingleDimensionArray<int>.FindValue(populatedArray, 6);

            // Assert 

            Assert.AreEqual(index, 5);
            }
    }
}

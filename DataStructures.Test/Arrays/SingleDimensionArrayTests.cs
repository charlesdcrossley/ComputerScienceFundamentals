using Bogus;
using DataStructures.Arrays;
using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataStructures.Test.Arrays
{
    [TestClass]
    public class SingleDimensionArrayTests
    {
        private Faker _faker = new Faker();

        [TestMethod]
        public void DeclareEmptyArray_WhenGivenNumberOfElementsAndType_ReturnsEmptyArrayOfSize()
        {
            // Arrange 

            int arraySize = 40;

            // Act 
            string[] emptyArray = SingleDimensionArray.DeclareEmptyArray<string>(arraySize);

            // Assert 

            Assert.AreEqual(arraySize, emptyArray.Length);

        }

        [TestMethod]
        public void PopulateEmptyArray_WhenGivenEmptyArrayAndListOfElements_ReturnsPopulatedArray()
        {
            // Arrange
            string[] emptyArray = SingleDimensionArray.DeclareEmptyArray<string>(40);

            var randomStrings = Enumerable.Range(1, 40).Select(f => _faker.Random.AlphaNumeric(10)).ToList();

            // Act 
            var populatedArray = SingleDimensionArray.PopulateEmptyArray(emptyArray, randomStrings);

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
            int firstElement = SingleDimensionArray.GetFirstElement(populatedArray);

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
            int lastElement = SingleDimensionArray.GetLastElement(populatedArray);

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
            int nthElement = SingleDimensionArray.GetNthElement(populatedArray, 4);

            // Assert
            Assert.AreEqual(nthElement, expectedResult);

        }
        [TestMethod]
        public void FindValue_WhenGivenArrayAndValue_ReturnsIndex()
        {
            // Arrange
            int[] populatedArray = [1, 2, 3, 4, 5, 6, 6, 8, 9, 10];

            // Act

            int index = SingleDimensionArray.FindValue(populatedArray, 6);

            // Assert 

            Assert.AreEqual(index, 5);
            }
    }
}

using Bogus;
using DataStructures.Array;
using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Test.Arrays
{
    [TestClass]
    public class SingleDimensionArrayTests
    {
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
            var randomStrings = Faker.Lorem.Words(40).ToList();

            // Act 
            var populatedArray = SingleDimensionArray.PopulateEmptyArray(emptyArray, randomStrings);

            // Assert 
            CollectionAssert.AllItemsAreNotNull(populatedArray);
        }
    }
}

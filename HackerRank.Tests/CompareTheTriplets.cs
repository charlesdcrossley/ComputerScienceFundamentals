using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRank.Algorithms.Warmups;
namespace HackerRank.Test
{
    [TestClass]
    public class CompareTheTripletsTests
    {
        [TestMethod]
        public void CompareTheTriplets_WhenThereIsATie_ReturnsPoints()
        {
            // Arrange

            List<int> aliceRatings = new List<int>()
            {
                1,2,3
            };
            List<int> bobRatings = new List<int>()
            {
                3,2,1
            };

            List<int> expectedResult = new List<int>()
            {
                1,1
            };
            // Act 
            var result = CompareTheTriplets.compareTriplets(aliceRatings, bobRatings);

            // Assert 

            CollectionAssert.AreEqual(result, expectedResult);
        }
        [TestMethod]
        public void CompareTheTriplets_WhenAliceWins_ReturnsPoints()
        {
            // Arrange

            List<int> aliceRatings = new List<int>()
            {
                17,28,30

            };
            List<int> bobRatings = new List<int>()
            {
                99,16,8
            };

            List<int> expectedResult = new List<int>()
            {
                2,1
            };

            // Act 
            var result = CompareTheTriplets.compareTriplets(aliceRatings, bobRatings);

            // Assert 

            CollectionAssert.AreEqual(result, expectedResult);
        }


    }
}

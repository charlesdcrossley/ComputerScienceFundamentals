using HackerRank.Arrays;
using Practice.HackerRank.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Tests
{
    [TestClass]
    public class DynamicArrayTests
    {
        [TestMethod]
        public void DynamicArray_WhenGivenIntegerAnd2DArrayOfQueries_ReturnsCorrectIntegerArray()
        {
            // Arrange
            string txtInput = GetFilePath(@"Input\DynamicArray.QueryProcessor.txt");
            string txtExpectedOutput = GetFilePath(@"ExpectedOutput\DynamicArray.QueryProcessor.txt");
            
            StreamReader input = new StreamReader(txtInput);
            StreamReader expectedOutput = new StreamReader(txtExpectedOutput);

            string[] firstMultipleInput = input.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int q = Convert.ToInt32(firstMultipleInput[1]);

            List<List<int>> queries = new List<List<int>>();

            for (int i = 0; i < q; i++)
            {
                queries.Add(input.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }

            List<int> expected = new List<int>();

            string t = String.Empty;
            while (!String.IsNullOrEmpty(t = expectedOutput.ReadLine()))
            {
                expected.Add(Convert.ToInt32(t));
            }

            // Act 
            List<int> result = DynamicArray.QueryProcessor(n, queries);
            

            // Assert
            CollectionAssert.AreEqual(result, expected);

        }

        private string GetFilePath(string fileName)
        {
            return Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), fileName)); 
        }
    }
}

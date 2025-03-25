using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Test
{
    [TestClass]
    public class FileReaderTests
    {
        [TestMethod]
        public void ReadIntegersFromFile_WhenPassedValidIntegersFromFile_ReturnsIEnumerableWithIntegers()
        {
            int[] array = new int[10];
            array = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            var outputIntegers = FileReader.ReadIntegersFromFile(@"TestData\1Kints.txt");

            Assert.IsTrue(outputIntegers.All(x => x is int));

        }
        [TestMethod]
        public void ReadIntegersFromFile_WhenPassedNonIntegersFromFile_SkipsLine()
        {            
            var outputIntegers = FileReader.ReadIntegersFromFile(@"TestData\1KintsNotInt.txt");

            Assert.IsTrue(outputIntegers.All(x => x is int));
        }

    }
}

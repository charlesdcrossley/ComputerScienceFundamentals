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
            var outputIntegers = FileReader.ReadIntegersFromFile("1Kints.txt");

            Assert.IsTrue(outputIntegers.All(x => x is int));

        }
        [TestMethod]
        public void ReadIntegersFromFile_WhenPassedNonIntegersFromFile_SkipsLine()
        {
            var outputIntegers = FileReader.ReadIntegersFromFile("1KintsNotInt.txt");

            Assert.IsTrue(outputIntegers.All(x => x is int));
        }

    }
}

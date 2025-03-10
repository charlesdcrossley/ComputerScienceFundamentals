using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class FileReader
    {
        public static IEnumerable<int> ReadIntegersFromFile(string filePath)
        {   
            string line = string.Empty;

            using (TextReader reader = new StreamReader(filePath))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    if(int.TryParse(line, out int value))
                    {
                        yield return value;
                    }

                }
            }
        }
    }
}

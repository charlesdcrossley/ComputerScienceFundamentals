using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Array
{
    public class SingleDimensionArray
    {
        public static T[] DeclareEmptyArray<T>(int numberOfElements)
        {
            T[] array = new T[numberOfElements];
            return array;
        }
        public static T[] PopulateEmptyArray<T>(T[] emptyArray, List<T> values)
        {
            if (emptyArray.Length != values.Count)
                throw new ArgumentException("Empty Array and Values don't match");

            for(int i=0; i<=emptyArray.Length-1; i++)
            {
                emptyArray[i] = values[i];
            }
            return emptyArray;
        }
    }
}

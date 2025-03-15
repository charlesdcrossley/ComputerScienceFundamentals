using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
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
        public static T GetFirstElement<T>(T[] populatedArray)
        {
            return populatedArray[0];
        }
        public static T GetLastElement<T>(T[] populatedArray)
        {
            return populatedArray[populatedArray.Length - 1];
        }
        public static T GetNthElement<T>(T[] populatedArray, int n)
        {
            return populatedArray[n];
        }
        public static int FindValue<T>(T[] populatedArray, T value)
        {
            Array.Sort<T>(populatedArray);
            return Array.BinarySearch<T>(populatedArray,value);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class SingleDimensionArray<T>
    {
        private T[] _array;
        public SingleDimensionArray(int numberOfElements)
        {
            _array = new T[numberOfElements];
        }
        public T[] GetArray()
        { 
            return _array;
        }
        
        public static T[] PopulateEmptyArray<T>(T[] emptyArray, List<T> values)
        {
            if (emptyArray.Length != values.Count)
                throw new ArgumentException("Empty Array and Values don't match");

            T[] populatedArray = emptyArray;

            for(int i=0; i<=emptyArray.Length-1; i++)
            {
                populatedArray[i] = values[i];
            }
            return populatedArray;
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

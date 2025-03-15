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
        private int _size; 
        public SingleDimensionArray(int numberOfElements)
        {
            _array = new T[numberOfElements];
            _size = numberOfElements;
        }
        public T[] GetArray()
        { 
            return _array;
        }
        public int GetSize()
        { 
            return _size; 
        }

        
        public static T[] PopulateEmptyArray(T[] emptyArray, List<T> values)
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
        public static T GetFirstElement(T[] populatedArray)
        {
            return populatedArray[0];
        }
        public static T GetLastElement(T[] populatedArray)
        {
            return populatedArray[populatedArray.Length - 1];
        }
        public static T GetNthElement(T[] populatedArray, int n)
        {
            return populatedArray[n];
        }
        public static int FindValue(T[] populatedArray, T value)
        {
            Array.Sort<T>(populatedArray);
            return Array.BinarySearch(populatedArray,value);
        }

    }
}

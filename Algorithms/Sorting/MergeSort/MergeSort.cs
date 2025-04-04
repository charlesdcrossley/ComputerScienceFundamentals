using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.MergeSort
{
    public class MergeSort
    {
        public static int[] Sort(int[] unsortedArray)
        {
            if (unsortedArray.Length <= 1)
                return unsortedArray;

            int midPoint = unsortedArray.Length / 2;

            int[] leftSegment = GetArraySegment(unsortedArray, 0, midPoint - 1);
            int[] rightSegment = GetArraySegment(unsortedArray, midPoint,unsortedArray.Length-1);

            Sort(leftSegment);
            Sort(rightSegment);
            Merge(unsortedArray,leftSegment, rightSegment);
            return unsortedArray;
        }
        private static void Merge(int[] mergedArray, int[] arrayA, int[] arrayB)
        {
            int arrayAIndex = 0;
            int arrayBIndex = 0;
            int mergedArrayIndex = 0;

            while(arrayAIndex < arrayA.Length && arrayBIndex < arrayB.Length)
            {
                if (arrayA[arrayAIndex] < arrayB[arrayBIndex])
                    mergedArray[mergedArrayIndex++] = arrayA[arrayAIndex++];
                else
                    mergedArray[mergedArrayIndex++] = arrayB[arrayBIndex++];
            }

            while (arrayAIndex < arrayA.Length)
                mergedArray[mergedArrayIndex++] = arrayA[arrayAIndex++];

            while (arrayBIndex < arrayB.Length)
                mergedArray[mergedArrayIndex++] = arrayB[arrayBIndex++];

        }
        private static int[] GetArraySegment(int[] unsortedArray, int startIndex, int endIndex)
        {
            int[] result = new int[endIndex - startIndex + 1];
            Array.Copy(unsortedArray, startIndex, result, 0, endIndex - startIndex + 1);
            return result;
        }
    }
}

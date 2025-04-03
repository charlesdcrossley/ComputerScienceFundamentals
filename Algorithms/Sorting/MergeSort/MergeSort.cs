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
            int[] rightSegment = GetArraySegment(unsortedArray, 0, midPoint - 1);

            Sort(leftSegment);
            Sort(rightSegment);
            int i = 0, j=0, k = 0;
            while (i< leftSegment.Length && j < rightSegment.Length)
            {
                if (leftSegment[i] <= rightSegment[j])
                    unsortedArray[k] = leftSegment[i++];
                else
                    unsortedArray[k] = rightSegment[j++];
                k++;
            }
            while (i < leftSegment.Length)
                unsortedArray[k++] = leftSegment[i++];
            while (j < rightSegment.Length)
                unsortedArray[k++] = rightSegment[j++];

            return unsortedArray;
        }
        private static int[] GetArraySegment(int[] unsortedArray, int startIndex, int endIndex)
        {
            int[] result = new int[endIndex - startIndex + 1];
            Array.Copy(unsortedArray, startIndex, result, 0, endIndex - startIndex + 1);
            return result;
        }
    }
}

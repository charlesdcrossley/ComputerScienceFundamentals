using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.InsertionSort
{
    public class InsertionSort
    {
        public static int[] Sort(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                int j = i;
                while(j > 0 && unsortedArray[j] < unsortedArray[j-1])
                {
                    unsortedArray = swapValues(unsortedArray, j, j-1);
                    j--;
                }
            }
            return unsortedArray;
        }
        private static int[] swapValues(int[] array, int indexA, int indexB)
        {
            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;
            return array;
        }
    }
}

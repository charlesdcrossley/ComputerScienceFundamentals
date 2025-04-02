using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.BubbleSort
{
    public class BubbleSort
    {
        public static int[] Sort(int[] unsortedArray)
        {
            for(int i=0; i<unsortedArray.Length; i++)
            {
                for(int j=0; j<unsortedArray.Length-1;j++)
                {
                    if (unsortedArray[j] > unsortedArray[j + 1])
                        swapValues(unsortedArray, j, j + 1);
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

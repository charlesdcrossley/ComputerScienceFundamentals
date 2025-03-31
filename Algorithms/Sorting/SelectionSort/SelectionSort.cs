using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting.SelectionSort
{
    public class SelectionSort
    {
        public static int[] Sort(int[] arrayOfIntegers)
        {
            for(int i=0; i<arrayOfIntegers.Length -1 ; i++)
            {
                int swapIndex = i;
                int swapValue = arrayOfIntegers[i];
                for (int j=i + 1; j<arrayOfIntegers.Length-1; j++)
                {                    
                    if (arrayOfIntegers[j] < swapValue)
                    {
                        swapIndex = j;
                        swapValue = arrayOfIntegers[j];
                    }
                }
                arrayOfIntegers  = swapValues(arrayOfIntegers, i, swapIndex);
                
            }
            return arrayOfIntegers;
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

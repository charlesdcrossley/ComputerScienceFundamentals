# Bubble Sort Algorithm

## What is Bubble Sort?
Bubble Sort starts from the beginning of the aray, scans right, two elements at a time and swaps them if they are not in the proper order, then starts back from the next index from the beginning

## Array to Sort
<img src="unsorted-array.png" width="400">


## Algorithm
```bash
FOR i = 0 to Array Length
   FOR j = 1 to Array Length
       IF [j] is less than [j+1], swap elements
   NEXT j
   END FOR
NEXT i
END FOR 
```
<img src="bubble-sort.png">

## Code 
```CSharp
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
```
## What is the Time Complexity ?

##### Worst Case 
 $O(n^2)$

##### Average Case
$O(n^2)$

## Why is the Time Complexity $O(n^2)$

Because the sort requires a nested for loop, causing the number of operations to grow quadratically as the inputs get larger

## Adapted From 

- Jamro, M. (2024). C# Data Structures and Algorithms (2nd ed.). Packt Publishing.

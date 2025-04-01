# Insertion Sort Algorithm

## What is Insertion Sort?
Similar to the Selection Sort, where it builds the sorted array from the left to right, but the Insertion Sort takes the first element from the right (unsorted) section of the array and puts it in the correct spot of the left (sorted) segment.

## Array to Sort
<img src="unsorted-array.png" width="400">


## Algorithm
```bash
FOR i = 0 to Array Length
   FOR j = 1 to Array Length
       First Element in [j] moved to correct position in [i]  
   NEXT j
   END FOR
NEXT i
END FOR 
```
<img src="insertion-sort-algorithm.png" width="600">


## Code 
```CSharp

```
## What is the Time Complexity ?

##### Worst Case 
 $O(n^2)$

##### Average Case
$O(n^2)$

## Why is the Time Complexity $O(n^2)$

Because the sort requires a while loop looping backwards, causing the number of operations to grow quadratically as the inputs get larger


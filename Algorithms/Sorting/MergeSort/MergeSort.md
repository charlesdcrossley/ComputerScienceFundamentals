# Selection Sort Algorithm

## What is Merge Sort?
Merge Sort splits the array in half and sorts over and over again (recursively) and then pieces the array back together sorted 

## What is recursion?
Recursion is a method where the function calls itself to achieve a certain output

## Array to Sort
<img src="unsorted-array.png" width="400">


## Algorithm

```
FUNCTION Sort (Array of Integers)
    leftSegmentArray = Split array in half and get left segment
    rightSegmentArray = Split array in half and get left segment

    Sort(leftSegmentArray)
    Sort(rightSegmentArray)

    Merge Sorted Segments back into Array 
END FUNCTION
```

![alt text](<merge-sort.png>)


## Code 
```CSharp

```
## What is the Time Complexity ?

##### Worst Case 

##### Average Case

## Why is the Time Complexity $O(n^2)$

## Adapted From 

- Jamro, M. (2024). C# Data Structures and Algorithms (2nd ed.). Packt Publishing.

# [Section 3 - Introduction to Algorithm Analyis](https://www.udemy.com/course/algorithms-data-structures-csharp/learn/lecture/12727527#overview)


## Problem Statement
Iterate over a set of integer numbers and find all of the triplets summing which the result will be 0

## Definitions: 

1. **Time Complexity** : How much time will it take to iterate through the integers to find the correct solution  

2. **Space Complexity** : How much memory will be used in iterating through the numbers to find the correct solution 

## Sample Data Acquired from Engineer Spocks content download : 


**1Kints.txt**

### Sample data set :

 324110    
-442472     
 626686   
-157678   
 508681   
 123414   
 -77867  
 155091   
 129801  
 287381  
 604242  
 
#### Triplet Check Example :  
> 324110 - 442472 + 626686 = 0 ? N :x:
 
> -442472 + 626686 - 157678 = 0 ? N :x:

> -442472 + 155091 + 287381 = 0 ? Y  :heavy_check_mark:

#### Brute Force Coding Approach :

```csharp
public static int EqualZeroCountCubicComplexity(int[] a)
{
    int n = a.Length;
    int counter = 0;

    for (int i = 0; i < n; i++)
    {
        for(int j = i +1; j < n; j++)
        {
            for (int k = j + 1; k < n; k++)
            {
                if (a[i] + a[j] + a[k] == 0)
                    counter++;
            }
        }
    }
    return counter;
}
```
### Results from Code : 

![alt text](../../images/AlgorithmAnalysis/ThreeSum/results.png)


### Points plotted on a graph: 

$(Input Size, Execution Time(Milliseconds))$

$(1000,610)$
$(4000,54442)$
$(8000,461309)$

![alt text](<desmos-graph (1)-1.png>)

### Calculate Slope : 

![alt text](../../images/AlgorithmAnalysis/ThreeSum/find-slope.png)

Roughly 3

=> T  (n) = 3n + b


=> $log{_2}{(T(n))} = 3log{_2}n  + log{_2}a$ **- a is constant**




>**Logarithm Product Rule** 
>$log{_b}(M^k) = k log{_b}M$

>**Logarithm Addition Rule** 
>$log{_b}(MN) = log{_b}M + log{_bN}$


Apply Product Rule => $log{_2}{(T(n))} =  log{_2}(n^3)  + log{_2}a$ **- a is constant**

Apply Addition Rule => $log{_2}{(T(n))} = a* N^3$


=> $T(n) = aN^3$


We can solve for (a) by plugging in one of our known plotted points: 


$T(1000) = a*1000^3$
=> $610 = a*1000^3$
=> $61*10^{-8}$

We can now predict the runtime for a given input size: 

$T(n) = 61*10^{-8} *n^3$

![alt text](<../../images/AlgorithmAnalysis/ThreeSum/desmos-graph-execution-time-per-input-size.png>)

https://www.desmos.com/calculator/hrrxbuwlcr  




References:  

 https://www.symbolab.com/solver/logarithmic-equation-calculator  
 https://www.udemy.com/course/algorithms-data-structures-csharp  
 https://www.chilimath.com/lessons/advanced-algebra/logarithm-rules/  
 https://www.desmos.com/  
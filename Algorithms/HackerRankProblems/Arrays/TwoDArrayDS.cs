using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.HackerRankProblems.Arrays
{
    //https://www.hackerrank.com/challenges/2d-array/problem
    public class TwoDArrayDS
    {
        public static int HourglassSum(List<List<int>> arr)
        {
            int maxsum = int.MinValue;
            for (int i = 0; i < arr.Count-2; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < arr[i].Count-2; j++)
                {
                    var topHourlass = arr[i][j] + arr[i][j+1] + arr[i ][j+2];
                    var middleHourglass = arr[i + 1][j + 1];
                    var bottomHourglass = arr[i+2][j] + arr[i+2][j + 1] + arr[i+2][j + 2];

                    var hourGlassSum = topHourlass + middleHourglass + bottomHourglass;

                    if (hourGlassSum > maxsum)
                        maxsum = hourGlassSum;
                }
            }
            return maxsum;
        }
    }
}

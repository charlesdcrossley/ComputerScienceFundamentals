using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCodeProblems.AmazonInverviewQuestions
{
    public class MergeIntervals
    {
        //https://leetcode.com/problems/merge-intervals
        
        public static int[][] Merge(int[][] intervals)
        {
            int[][] sortedArray = intervals.OrderBy(x => x[0]).ToArray();
            var outputArray = new List<int[]>();

            int startInterval = 0;
            int endInterval = 1;

            for (int i=0; i<=sortedArray.Length-1; i++)
            {
                if(i == sortedArray.Length-1)
                    outputArray.Add([sortedArray[i][startInterval], sortedArray[i][endInterval]]);

                else if (sortedArray[i][endInterval] >= sortedArray[i + 1][startInterval])
                {
                    outputArray.Add([sortedArray[i][startInterval], sortedArray[i + 1][endInterval]]);
                    i++;
                }   

                else
                    // TODO Refactor to remove Code Duplication 
                    outputArray.Add([sortedArray[i][startInterval], sortedArray[i][endInterval]]);
                            }
            return outputArray.ToArray();
        }
    }
}

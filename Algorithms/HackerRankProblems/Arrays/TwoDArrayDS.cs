using System;
using System.Collections.Generic;
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
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < arr[i].Count; j++)
                {
                    Console.Write(" Column " + arr[i][j]);
                }

            }
            return 0;
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LeetCodeProblems.AmazonInverviewQuestions.TwoSum
{
    public class TwoSum
    {
        // https://leetcode.com/problems/two-sum
        // Brute Force - O(n^2)
        public static int[] TwoSumQuadraticComplexity(int[] nums, int target)
        {
            for(int i =0; i<= nums.Length; i++)
            {
                for (int j = 0; j <= nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return [i, j];
                }
            }

            return null;
        }
        public static int[] TwoSumLinearComplexity(int[] nums, int target)
        {
            Dictionary<int, int> hashMap = new Dictionary<int, int>();

            for(int i=0; i<= nums.Length; i++)
            {
                int compliment = target - nums[i];
                if (hashMap.ContainsKey(compliment))
                    return [hashMap[compliment], i];
                hashMap[nums[i]] = i;
            }
            return [];
        }
    }
}

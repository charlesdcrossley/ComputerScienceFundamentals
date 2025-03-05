using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.LeetCode.AmazonInterviewQuestions
{
    public class MergeSortedArray
    {
        // https://leetcode.com/problems/merge-sorted-array
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if(nums2.Length == 0) return;

            int[] temp = new int[m + n];

            for (int i=0,j = 0,k=0 ; j < m;)
            {   
                if((nums1[i] <= nums2[j]) && i!=m )
                {
                    temp[k] = nums1[i];
                    i++;
                    k ++; 
                }
                else 
                {
                    temp[k] = nums2[j];
                    j++;
                    k ++;
                }
            }

            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = temp[i];
                
            }
        }
    }
}

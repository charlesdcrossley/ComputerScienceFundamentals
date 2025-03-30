using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.InterviewPrep.OneWeek
{
    public class DayTwo
    {
        //https://www.hackerrank.com/challenges/one-week-preparation-kit-lonely-integer/
        public static int Lonelyinteger(List<int> a)
        {
            Dictionary<int, int> lookup = new Dictionary<int, int>();
            for (int i = 0; i < a.Count; i++)
            {
                // key = number
                // value = count of number 
                if (lookup.TryGetValue(a[i], out int count))
                    lookup[a[i]] = ++count;
                else
                    lookup.Add(a[i], 1);
            }

            return lookup.FirstOrDefault(x => x.Value == 1).Key;
        }
        public static int DiagonalDifference(List<List<int>> arr)
        {
            int leftToRight = 0;
            int rightToLeft = 0;
            int count = arr.Count;

            for (int i = 0, j = count - 1; i < arr.Count; i++, j--)
            {
                leftToRight = leftToRight + arr[i][i];
                rightToLeft = rightToLeft + arr[i][j];
            }

            return Math.Abs(leftToRight - rightToLeft);
        }
        public static List<int> CountingSort(List<int> arr)
        {
            List<int> count = Enumerable.Repeat(0, 100).ToList();            

            for (int i=0; i<arr.Count;i++ )
            {                
                    count[arr[i]] = count[arr[i]] + 1;
            }

            return count;
        }
        public static int FlippingMatrix(List<List<int>> matrix)
        {
            int sum = 0;
            int n = matrix.Count/2;

            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<n; j++)
                {
                    int topLeft = matrix[i][j];
                    int topRight = matrix[i][2 * n - 1 - j];
                    int bottomLeft = matrix[2 * n - 1 - i][j];
                    int bottomRight = matrix[2 * n - 1 - i][2 * n - 1 - j];

                    sum = sum + Math.Max(topLeft, Math.Max(topRight, Math.Max(bottomLeft, bottomRight)));
                }
            }

            return sum;
        }
    }
}

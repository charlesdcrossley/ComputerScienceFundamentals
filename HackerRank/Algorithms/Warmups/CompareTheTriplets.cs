using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Warmups
{
    public class CompareTheTriplets
    {
        //https://www.hackerrank.com/challenges/compare-the-triplets/
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> totalScore = new List<int>()
            {
                0,0
            };

            for(int i = 0; (i<=a.Count - 1 || i<=b.Count -1); i++)
            {
                if (a[i] > b[i])
                    totalScore[0] = totalScore[0] + 1;
                else if (b[i] > a[i])
                    totalScore[1] = totalScore[1] + 1;
                
            }

            return totalScore;

        }
    }
}

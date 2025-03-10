using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Arrays
{
    public class DynamicArray
    {

        //https://www.hackerrank.com/challenges/dynamic-array/

        public static List<int> QueryProcessor(int n, List<List<int>> queries)
        {
            List<List<int>> arr = new List<List<int>>();
            List<int> answers = new List<int>();
            int lastAnswer = 0;

            for (int i = 0; i <= n; i++)
            {
                arr.Add(new List<int>());
            }
                

            foreach (var query in queries)
            {
                int idx = (query[1] ^ lastAnswer) % n ;
                if (query.First() == 1)
                {
                    arr[idx].Add(query[2]);
                }
                else
                {
                    lastAnswer = arr[idx][query[2] % arr[idx].Count];
                    answers.Add(lastAnswer);
                }
            }

            return answers;

        }
    }
}

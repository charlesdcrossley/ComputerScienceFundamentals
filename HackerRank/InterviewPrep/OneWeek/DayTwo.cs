using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.InterviewPrep.OneWeek
{
    public class DayTwo
    {
        //https://www.hackerrank.com/challenges/one-week-preparation-kit-lonely-integer/
        public static int Lonelyinteger(List<int> a)
        {
            Dictionary<int, int> lookup = new Dictionary<int,int>();
            for(int i = 0; i<a.Count; i++)
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

    }
}

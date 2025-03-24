using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.InterviewPrep.OneWeek
{
    public class DayOne
    {
        //https://www.hackerrank.com/challenges/one-week-preparation-kit-plus-minus/
        public static void plusMinus(List<int> arr)
        {
            int positiveIntegers = 0;
            int negativeIntegers = 0;
            int zeroIntegers = 0;
            int n = arr.Count();
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    positiveIntegers++;
                }
                else if (arr[i] <0)
                {
                    negativeIntegers++;
                }
                else
                {
                    zeroIntegers++;
                }
            }

            double positiveNumberRatio = (double)positiveIntegers / n;
            double negativeNumberRatio = (double)negativeIntegers / n;
            double zeroIntegerRatio = (double)zeroIntegers / n;

            Console.WriteLine(Math.Round(positiveNumberRatio,6).ToString("N6"));
            Console.WriteLine(Math.Round(negativeNumberRatio, 6).ToString("N6"));
            Console.WriteLine(Math.Round(zeroIntegerRatio, 6).ToString("N6"));

        }
        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();            

            long median = 0;
            long min = 0;
            long max = 0;

            for(int i = 1; i < arr.Count()-1; i++)
            {
                median = median + arr[i];
            }

            min = median + arr[0];
            max = median + arr[arr.Count-1];

            Console.WriteLine(min.ToString() + " " + max.ToString());
        }
    }
}

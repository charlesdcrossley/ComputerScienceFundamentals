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
                
    }
}

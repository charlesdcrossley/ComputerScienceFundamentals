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
        public static void PlusMinus(List<int> arr)
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

        //https://www.hackerrank.com/challenges/one-week-preparation-kit-mini-max-sum
        public static void MiniMaxSum(List<int> arr)
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
        public static string TimeConversion(string s)
        {
            var amPm = s.Substring(s.Length - 2);
            var rawtime = s.Substring(0,s.Length - 2);

            var splitTime = rawtime.Split(":");

            var hour = Int32.Parse(splitTime[0]) ;
            var minute = Int32.Parse(splitTime[1]);
            var second = Int32.Parse(splitTime[2]);

            
            switch (amPm)
            {                
                case "PM":
                    hour = hour == 12 ? hour : hour + 12;
                    break;
                case "AM":
                    hour = hour == 12 ? 0 : hour;
                    break;
            }    

            return $"{hour.ToString("00")}:{splitTime[1]}:{splitTime[2]}";
        }

        public static int FindMedian(List<int> arr)
        {
            arr.Sort();

            return (arr[arr.Count / 2]);

        }
    }
}

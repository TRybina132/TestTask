using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTasks
{
    public class ArrayOperations
    {
        public static int GetDigits(int number) => Convert.ToInt32(Math.Floor(Math.Log10(Math.Abs(number)) + 1));
        public static void CheckIfMin(ref int min, int current) => min = current < min ? current : min;
        public static void CheckIfMax(ref int max, int current) => max = current > max ? current : max;
        public static void Process(int[] arr)
        {
            int sumA = 0;
            int minA = arr[0], maxA = arr[0];
            arr.ToList().ForEach(num => 
            {
                switch (GetDigits(num))
                {
                    case 1: CheckIfMin(ref minA, num); break;
                    case 2: sumA += num; break;
                    case 3: CheckIfMax(ref maxA, num); break;
                }
            });

            Console.Write($"min value of one-digit number: {minA}\n"
                + $"Sum of two-digits numbers: {sumA} \n" 
                + $"max value of three-digit number: {maxA}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stydy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] { 1, 2, 0 };
            FirstMissingPositive(ints);

        }

        public static int[] RunningSum(int[] nums)
        {
            int sum = 0;
            int[] ints = new int[nums.Length];
           
                for (int j = 0; j < nums.Length; j++)
                {
                    sum += nums[j];
                    ints[j] = sum;
                }

            return ints;
        }

        public static int FirstMissingPositive(int[] nums)
        {
            int min = nums.Min();
            int max = nums.Max();

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != min+1)
                {
                    min = nums[i];
                }
            }
            if (min == max)
            {
                min++;
            }
            return min;
        }
    }
}

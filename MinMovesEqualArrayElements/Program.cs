using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///Given an integer array nums of size n, return the minimum number of moves required to make all array elements equal.
///In one move, you can increment or decrement an element of the array by 1.
///Test cases are designed so that the answer will fit in a 32-bit integer.
///</summary>
namespace MinMovesEqualArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] { 1, 10, 2, 9};
            Console.WriteLine(MinMoves2(ints));
            Console.ReadLine();
        }


        public static int MinMoves2(int[] nums)
        {
            if (nums.Distinct().Count() == 1)
            {
                return 0;
            }
            int result = 0;
            int count = nums.Count();
            Array.Sort(nums);
            int median;

            if (nums.Count() %2 ==0)
            {
                var temp = nums[ count / 2];
                var temp1 =  nums[count / 2 - 1];
                var temp3 = temp + temp1 / 2;
                median = temp3;
            }
            else median = nums[nums.Count() / 2];
           

            for (int i = 0; i < nums.Length; i++)
            {
                result += Math.Abs(nums[i] - median);
            }
            return result;

        }
    }
}

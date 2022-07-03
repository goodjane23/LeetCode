using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>A wiggle sequence is a sequence where the differences between successive numbers strictly alternate between positive and negative.
///The first difference (if one exists) may be either positive or negative. A sequence with one element and a sequence with two non-equal
///elements are trivially wiggle sequences.
///For example, [1, 7, 4, 9, 2, 5] is a wiggle sequence because the differences (6, -3, 5, -7, 3) alternate between positive and negative.
///In contrast, [1, 4, 7, 2, 5] and [1, 7, 4, 5, 5] are not wiggle sequences. The first is not because its first two differences are positive,
///and the second is not because its last difference is zero.
///A subsequence is obtained by deleting some elements (possibly zero) from the original sequence, leaving the remaining elements in their original order.
///Given an integer array nums, return the length of the longest wiggle subsequence of nums.
///</summary>
///
namespace WiggleSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WiggleMaxLength(new int[] { 1, 17, 5, 10, 13, 15, 10, 5, 16, 8 });
        }
        public static int WiggleMaxLength(int[] nums)
        {
            if (nums.Length <= 2)
                return nums.Length;
            int positive = 1;
            int negative = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[i - 1])
                    positive = negative + 1;
                else if (nums[i] < nums[i - 1])
                    negative = positive + 1;
            }
            if (negative > positive)
                return negative;
            else return positive;


        }
    }
}
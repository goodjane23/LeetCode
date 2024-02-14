/// <summary>
/// You are given a 0-indexed integer array nums of even length consisting of an equal number of positive and negative integers.
/// You should rearrange the elements of nums such that the modified array follows the given conditions:
/// Every consecutive pair of integers have opposite signs.
/// For all integers with the same sign, the order in which they were present in nums is preserved.
/// The rearranged array begins with a positive integer.Return the modified array after rearranging the elements to satisfy the aforementioned conditions.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        RearrangeArray([3, 1, -2, -5, 2, -4]);
        RearrangeArray([-1, 1]);
    }
    public static int[] RearrangeArray(int[] nums)
    {
        var result = new int[nums.Length];
        List<int> positive = new List<int>();
        List<int> negative = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                positive.Add(nums[i]);
            }
            else
            {
                negative.Add(nums[i]);
            }
        }
        var j = 0;
        var k = 0;
        for (int i = 0; i < result.Length; i++)
        {
            if (int.IsOddInteger(i))
            {
                result[i] = negative[j];
                j++;
            }
            else
            {
                result[i] = positive[k];
                k++;
            }
           
        }
        return result;
    }
}
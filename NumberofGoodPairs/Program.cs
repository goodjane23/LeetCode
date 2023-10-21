
using System.Diagnostics.CodeAnalysis;
/// <summary>
/// Given an array of integers nums, return the number of good pairs.
/// A pair(i, j) is called good if nums[i] == nums[j] and i<j
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        var res = NumIdenticalPairs(new int[]{ 1, 1, 1, 1 });
        Console.WriteLine($"Count is: {res}");
    }

    public static int NumIdenticalPairs(int[] nums)
    {
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {           
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] == nums[j]&& i<j)
                {
                    result++;
                }
            }    

        }
        return result;
    }
}
/// <summary>
/// You are a professional robber planning to rob houses along a street. Each house has a certain amount
/// of money stashed, the only constraint stopping you from robbing each of them is that adjacent houses 
/// have security systems connected and it will automatically contact the police if two adjacent houses
/// were broken into on the same night.
/// Given an integer array nums representing the amount of money of each house, return the maximum 
/// amount of money you can rob tonight without alerting the police.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = { 2, 1, 1, 2 };
        Console.WriteLine(Rob(nums));
    }

    public static int Rob(int[] nums)
    {
        int prevMax = 0;
        int currMax = 0;

        foreach (int num in nums)
        {
            int temp = currMax;
            currMax = Math.Max(prevMax + num, currMax);
            prevMax = temp;
        }

        return currMax;
    }
}
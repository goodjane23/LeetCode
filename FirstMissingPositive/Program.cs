/// <summary>
/// Given an unsorted integer array nums, return the smallest missing positive integer.
/// You must implement an algorithm that runs in O(n) time and uses O(1) auxiliary space.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(FirstMissingPositive([2, 1]));
        Console.WriteLine(FirstMissingPositive([1, 1]));
        Console.WriteLine(FirstMissingPositive([1, 2, 0]));
        Console.WriteLine(FirstMissingPositive([3, 4, -1, 1]));
        Console.WriteLine(FirstMissingPositive([7, 8, 9, 11, 12]));
        Console.Read();
    }

    public static int FirstMissingPositive(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }
        Array.Sort(nums);
        int res = 1;
        int temp = 0;

        foreach (int x in nums)
        {
            if (x <= res && x > 0)
            {
                if (temp == x) continue;
                res ++;
                temp = x; 

            }
        }
        return res;
    }
}
using System.Linq;
/// <summary>
/// Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
        Rotate(nums, 3);        
    }
    private static void Rotate(int[] nums, int k)
    {
        var list = nums.ToList();
        var kn = list.TakeLast(k);
        list.AddRange(kn);
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = list[i];
        }
    }
}
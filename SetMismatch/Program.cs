/// <summary>
/// You have a set of integers s, which originally contains all the numbers from 1 to n. Unfortunately, 
/// due to some error, one of the numbers in s got duplicated to another number in the set, which results in
/// repetition of one number and loss of another number.You are given an integer array nums representing the 
/// data status of this set after the error.Find the number that occurs twice and the number that is missing 
/// and return them in the form of an array.
/// </summary>

internal class Program
{
    private static void Main(string[] args)
    {

        FindErrorNums(new int[] { 1, 2, 2, 4 });
        FindErrorNums(new int[] { 3, 2, 2 });
        FindErrorNums(new int[] { 3, 3, 1 });
        FindErrorNums(new int[] { 2, 3, 2 });
        FindErrorNums(new int[] { 3, 2, 2 });
        FindErrorNums(new int[] { 2, 2 });
        FindErrorNums(new int[] { 1, 1 });

    }
    public static int[] FindErrorNums(int[] nums)
    {
        var res = new int[2];
        int f = 1;
        int l = nums.Length;
        for (int i = 0; i < l; i++)
        {
            var find = Array.FindAll(nums, x => x == nums[i]);
            if (find.Length == 2)
            {
                res[0] = find[0];
                break;
            }
        }
        for (int i = 0; i < l; i++)
        {
            var exist = nums.Any(x => x == f);
            if (!exist)
            {
                res[1] = f;
                break;
            }
            f++;
        }
        return res;
    }
}
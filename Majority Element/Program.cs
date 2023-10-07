 /// <summary>
 /// Given an array nums of size n, return the majority element.
 /// The majority element is the element that appears more than ⌊n / 2⌋ times.
 /// You may assume that the majority element always exists in the array.
 /// </summary>

public class Program
{
    public static void Main(string[] args)
    {
        var element = MajorityElement(new[] { 1,3,1,1,4,1,1,5,1,1,6,2,2 });
        Console.WriteLine($"The Majority element is: {element}");
    }
    
    public static int MajorityElement(int[] nums)
    {
        if (nums.Length == 1)
            return nums[0];
        
        Array.Sort(nums);
        int maxCount = 1;
        int count = 1;
        int result = 1;

        for (int i = 0; i < nums.Length-1; i++)
        {
            if (nums[i] != nums[i + 1])
            {
                if (maxCount < count)
                {
                    maxCount = count;
                    result = nums[i];
                }
                count = 1;
            }
               
            else
                count++;
        }

        return count > maxCount ? nums.Last() : result;
    }
}
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
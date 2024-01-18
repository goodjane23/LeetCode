/// <summary>
/// Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.
/// The overall run time complexity should be O(log (m+n)).
/// </summary>

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] num1 = { 1, 2};
        int[] num2 = { 3,4 };
        FindMedianSortedArrays(num1, num2);
    }

    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        double sum;
        List<int> ints = [.. nums1, .. nums2];
        ints.Sort();
        if (ints.Count % 2 == 0)
        {
            var m = ints.Count / 2;
            double a = ints[m - 1];
            double b = ints[m];
            sum = (a + b) / 2d;
        }
        else
        {
            var m = ints.Count / 2;
            sum = ints[m];
        }

        return sum;
    }
}
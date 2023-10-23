/// <summary>
/// Given an integer n, return true if it is a power of four. Otherwise, return false.
/// An integer n is a power of four, if there exists an integer x such that n == 4x.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"{IsPowerOfFour(1)}");
        Console.WriteLine($"{IsPowerOfFour(4)}");
        Console.WriteLine($"{IsPowerOfFour(-2147483648)}");
        Console.WriteLine($"{IsPowerOfFour(13)}");
        Console.WriteLine($"{IsPowerOfFour(49)}");

    }

    public static bool IsPowerOfFour(int n)
    {
        var log = Math.Log(n, 4);
        var intLog = (int)log;

        return intLog - log == 0;
    }
}
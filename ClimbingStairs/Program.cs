/// <summary>
/// You are climbing a staircase. It takes n steps to reach the top.
/// Each time you can either climb 1 or 2 steps. In how many distinct ways can you climb to the top?
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($" Для 45: {ClimbStairs(45)}");
        Console.WriteLine($" Для 3: {ClimbStairs(3)}");
        Console.WriteLine($" Для 4: {ClimbStairs(4)}");
        Console.WriteLine($" Для 5: {ClimbStairs(5)}");
        Console.WriteLine($" Для 6: {ClimbStairs(6)}");
    }
    public static int ClimbStairs(int n)
    {
        int result = 1;
        int b = 1;
        int tmp;

        for (int i = 0; i < n; i++)
        {
            tmp = result;
            result = b;
            b += tmp;
        }
        return result;
    }
}
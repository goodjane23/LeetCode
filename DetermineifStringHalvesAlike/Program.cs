internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(HalvesAreAlike("MerryChristmas"));
        Console.ReadLine();
    }

    public static bool HalvesAreAlike(string s)
    {
        var firstPart = s.Substring(0,s.Length/2);
        var secondPart = s.Substring(s.Length/2,s.Length/2);

        return GetVoString(firstPart) == GetVoString(secondPart);
    }
    public static int GetVoString(string str)
    {
        string vo = "aeiouyAEIOUY";
        string result = "";
        foreach (var part in str)
        {
            if (vo.Contains(part))
            {
                result += part;
            }
        }
        return result.Length;
    }
}
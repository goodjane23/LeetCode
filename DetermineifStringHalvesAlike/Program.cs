/// <summary>
/// You are given a string s of even length. Split this string into
/// two halves of equal lengths, and let a be the first half and b be the second half.
/// Two strings are alike if they have the same number of 
/// vowels ('a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U').
/// Notice that s contains uppercase and lowercase letters.
/// Return true if a and b are alike. Otherwise, return false.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
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
        string vo = "aeiouAEIOU";
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
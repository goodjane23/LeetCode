/// <summary>
/// Given an array of strings words, return the first palindromic string in the array. 
/// If there is no such string, return an empty string "".A string is palindromic if
/// it reads the same forward and backward.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(FirstPalindrome(["abc", "car", "ada", "racecar", "cool"]));
        Console.WriteLine(FirstPalindrome(["notapalindrome", "racecar"]));
        Console.WriteLine(FirstPalindrome(["def", "ghi"]));
    }

    public static string FirstPalindrome(string[] words)
    {
        foreach (string word in words)
        {
            if(IsPalindrome(word))
                return word;
        }

        return string.Empty;       
    }

    private static bool IsPalindrome(string s)
    {
        var temp = "";
        for (int i = s.Length-1; i >=0; i--)
        {
            temp += s[i];
        }
        return s.Equals(temp);
    }
}
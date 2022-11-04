// See https://aka.ms/new-console-template for more information

using System.Text;
using Microsoft.Win32.SafeHandles;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        IsPalindrome("A man, a plan, a canal: Panama");
    }
    private static bool IsPalindrome (string s)
    {
        s = s.ToLowerInvariant();
        var result = "";
        foreach (var charOfS in s)
        {
            if (Char.IsLetter(charOfS) || Char.IsNumber(charOfS))
                result += charOfS;
        }

        char[] charArray = result.ToCharArray();
        Array.Reverse(charArray);
        var temp = new string(charArray);
        return result == temp;
    }
}
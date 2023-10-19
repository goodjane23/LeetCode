using System;
using System.Reflection;
/// <summary>
/// Given two strings s and t, return true if they are equal when both are typed into empty 
/// text editors. '#' means a backspace character.
/// Note that after backspacing an empty text, the text will continue empty.
/// </summary>
public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"{BackspaceCompare("c#d#", "ab##")}");
        //true:
        Console.WriteLine($"{BackspaceCompare("ab#c", "ad#c")}");        
        Console.WriteLine($"{BackspaceCompare("a##c", "#a#c")}");
        //false:
        Console.WriteLine($"{BackspaceCompare("a#c", "b")}");        
        Console.WriteLine($"{BackspaceCompare("uio##cc", "uio###cc")}");
    }

    public static bool BackspaceCompare(string s, string t)
    {       
        return Transform(s).Equals(Transform(t));
    }

    private static string Transform(string s) 
    { 
        var result = string.Empty;

        for (int i = 0; i < s.Length-1; i++)
        {
            if (s[i] is '#')
            {
                if (result.Length>0)
                {
                    result = result.Remove(result.Length-1, 1);
                }
            }
            else
            {
                result+= s[i];
            }
        }
        if (s.Last() == '#' && result.Length>0)
        {
            result = result.Remove(result.Length-1,1);
        }
        else
        {
            result += s.Last();
        }
        return result;
    }
}
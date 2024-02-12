using System.Collections.Immutable;
using System.Text;

/// <summary>
/// Given a string s, find the first non-repeating character in it and return its index. 
/// If it does not exist, return -1.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        FirstUniqChar("Hello, World!");
        FirstUniqChar("loveleetcode");
        FirstUniqChar("leetcode");
        FirstUniqChar("aabb");
    }
    public static int FirstUniqChar(string s)
    {
        for (int i = 0; i < s.Length; i++)
        {
            var x1 = s.IndexOf(s[i]);
            var x2 = s.LastIndexOf(s[i]);
            if (x1 == x2 ) return i;
        }
      
        return -1;
    }

}
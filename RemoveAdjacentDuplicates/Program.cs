using System.Text;

/// <summary>
/// You are given a string s consisting of lowercase English letters. A duplicate removal consists of choosing two adjacent and equal letters and removing them.
/// We repeatedly make duplicate removals on s until we no longer can.
/// Return the final string after all such duplicate removals have been made. It can be proven that the answer is unique.
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        RemoveDuplicates("abbaca");
    }

    public static string RemoveDuplicates(string s)
    {
      
    }

}
//  var arr = s.ToArray();
// var temp = Array.FindAll(arr, x => s[i] == x);
// if (temp.Length == 1) sb.Append(s[i]);
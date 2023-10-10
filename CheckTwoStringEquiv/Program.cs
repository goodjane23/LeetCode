//Given two string arrays word1 and word2, return true if the two arrays represent the same
//string, and false otherwise. A string is represented by an array if the array
//elements concatenated in order forms the string.

using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        var res = ArrayStringsAreEqual(new[] { "test" }, new[] { "test" });
        Console.WriteLine($"{res}");
    }
    
    private static bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        StringBuilder s1 = new StringBuilder(); 
        StringBuilder s2 = new StringBuilder();
        
        for (int i = 0; i < word1.Length; i++)
            s1.Append(word1[i]);
        
        for (int i = 0; i < word2.Length; i++)
            s2.Append(word2[i]);
        
        return s1.Equals(s2);
    }
}
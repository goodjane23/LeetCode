using System.Text;

//Given a string s, reverse only all the vowels in the string and return it.
//The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ReverseVowels("aA");
    }
    private static string ReverseVowels(string s)
    {
        StringBuilder result = new StringBuilder();
        var vowels = "aeiouAEIOU";
        Dictionary<int, char> vow = new Dictionary<int, char>();

        for (int i = 0; i < s.Length; i++)
            if (vowels.Contains(s[i])) vow.Add(i, s[i]);
        
        var reversVow =  vow.Reverse().ToList();

        for (int i = 0; i < s.Length; i++)
        {
            if (vow.ContainsKey(i))
            {
                result.Append(reversVow.First().Value);
                reversVow.Remove(reversVow.First());
            }
            else result.Append(s[i]);
        }

        return result.ToString();
    }
}
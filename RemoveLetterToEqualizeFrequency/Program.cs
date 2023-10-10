/// <summary>
/// You are given a 0-indexed string word, consisting of lowercase English letters. 
/// You need to select one index and remove the letter at that index from word so that the frequency of every letter present in word is equal.
/// Return true if it is possible to remove one letter so that the frequency of all letters in word are equal, and false otherwise.
/// </summary>
public class Program
{
    private static void Main(string[] args)
    {
        //true:
        Console.WriteLine($"Result is: {EqualFrequency("cbbd")}");
        Console.WriteLine($"Result is: {EqualFrequency("abbcc")}");
        Console.WriteLine($"Result is: {EqualFrequency("abc")}");
        Console.WriteLine($"Result is: {EqualFrequency("abcc")}");
        Console.WriteLine($"Result is: {EqualFrequency("zz")}");
        //False:
        Console.WriteLine($"Result is: {EqualFrequency("ddaccb")}");        
        Console.WriteLine($"Result is: {EqualFrequency("aazz")}");
        Console.WriteLine($"Result is: {EqualFrequency("zzxfffxd")}");
        Console.ReadLine();
    }

    public static bool EqualFrequency(string word)
    {
        Dictionary<char,int> counts = new Dictionary<char,int>();
        Dictionary<int, int> valuePairs = new Dictionary<int, int>();

        //lets count the number of letters and repetitions
        foreach (char c in word)
        {
            if (counts.ContainsKey(c)) continue;
            var count = word.Count(x => x == c);
            counts.Add(c, count);
        }
        if (counts.Count == 1) return true;

        var keys = counts.Values.ToList();

        var countValues = keys.Distinct();
        if (countValues.Count() == 1 && keys[0] != 1 || countValues.Count() >2) return false;
        if (keys.Count(x => x == 1)==1) return true;
       
        foreach (var key in keys)
        {
            if (valuePairs.ContainsKey(key)) continue;
            var val = keys.Count(x => x == key);
            valuePairs.Add(key, val);
        }
        keys.Sort();
        var temp = keys[0];
        for (int i = 0; i < keys.Count-1; i++)
        {
            if (keys[i] != keys[i+1])
            {
                if (i != keys.Count - 2) return false;
                
                if (Math.Abs(keys[i + 1] - keys[i]) != 1)
                    return false;
            }
        }
        return true;
    }
}
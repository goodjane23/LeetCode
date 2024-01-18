using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

/// <summary>
/// Given an array of strings words and an integer k, return the k most frequent strings.
/// Return the answer sorted by the frequency from highest to lowest.
/// Sort the words with the same frequency by their lexicographical order.
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        TopKFrequent(["the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is"], 4);
    }

    private static IList<string> TopKFrequent(string[] words, int k)
    {
        var result = new List<string>();
        Array.Sort(words);
        Dictionary<string, int> map = new Dictionary<string, int>();
        
        foreach (var word in words)
        {
            var count = words.Count(x => x.Equals(word));
            if (map.ContainsKey(word)) { continue; }
            map.Add(word, count);
        }
        var temp = map
            .OrderByDescending(x => x.Value)
            .ToList();
       
        foreach (var word in temp)
        {
            result.Add(word.Key);
            if (k == result.Count) break;
        }
        return result;
    }
}
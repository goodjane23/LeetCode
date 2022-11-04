
class Program
{
    public static void Main(string[] args)
    {
        TopKFrequent(new[] { "i", "love", "leetcodes", "i", "love", "coding" }, 2);

    }

    private static IList<string> TopKFrequent(string[] words, int k)
    {
        var result = new List<string>();
        var temp = new List<int>();
        int max = 0;

        var countUnique = words.Distinct().ToList();
        if (countUnique.Count >= k)
            return countUnique;

        for (int i = 0; i < countUnique.Count; i++)
        {
            var x = Array.FindAll(words,x => x == countUnique[i]);
            
            temp.Add(x.Length);
            result.Add(countUnique[i]);
            if (temp.Count > k)
            {
                
            }
            
        }

        return result;

    }
}
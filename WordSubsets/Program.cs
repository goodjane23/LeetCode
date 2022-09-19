using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSubsets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = new string[] { "amazon", "apple", "facebook", "google", "leetcode" };
            string[] words2 = new string[] { "lo", "eo" };
            WordSubsets(words1, words2);
        }

        public static IList<string> WordSubsets(string[] words1, string[] words2)
        {
            int count = 0;
            IList<string> list = new List<string>();

            foreach (string word in words1)
            {
                for (int i = 0; i < words2.Count(); i++)
                {
                    if (word.Contains(words2[i]))
                        count++;
                }
                if (count == words2.Count())
                    list.Add(word);
                count = 0;
            }

            return list;
        }
    }
}

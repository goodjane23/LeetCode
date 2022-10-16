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
            string[] words1 = { "amazon", "apple", "facebook", "google", "leetcode" };
            string[] words2 = { "lo", "eo" };
            var result = WordSubsets(words1, words2);
            
            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
            
            Console.ReadLine();
        }

        private static IList<string> WordSubsets(string[] words1, string[] words2)
        {
            IList<string> list = new List<string>();
            var resultSub = words2[0];
            for (int i = 1; i < words2.Length-1; i++)
            {
              //  resultSub = resultSub.Union(resultSub, words2[i]);
            }
            
            return list;
        }
    }
}

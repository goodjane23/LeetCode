using System;
using System.Collections.Generic;
using System.Linq;

///You are given two string arrays words1 and words2.
///A string b is a subset of string a if every letter in b occurs in a including multiplicity.
///For example, "wrr" is a subset of "warrior" but is not a subset of "world".
///A string a from words1 is universal if for every string b in words2, b is a subset of a.
///Return an array of all the universal strings in words1. You may return the answer in any order.

namespace WordSubsets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words1 = { "amazon", "apple", "facebook", "google", "leetcode" };
            //facebook, google
            string[] words2 = { "e", "oo" };
            var result = WordSubsets(words1, words2);
            //["google","leetcode"]
            string[] words3 = { "le", "lo" };
            result = WordSubsets(words1, words3);

            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
            
            Console.ReadLine();
        }

        private static IList<string> WordSubsets(string[] words1, string[] words2)
        {
            IList<string> list = new List<string>();
            foreach (var word in words1)
            {
                var count = 0;

                foreach (var word2 in words2)
                {                   
                    if (IsPartOf(word, word2)) count++;
                    else break;

                    if (count == words2.Count()) list.Add(word);
                }
            }

            return list;
        }

        private static bool IsPartOf(string a, string b)
        { 
            var count = a.Length;
            for (int i = 0; i < b.Length; i++)
            {
                var index = a.IndexOf(b[i]);
                if (index == -1) return false;
                a = a.Remove(index, 1);                
            }
            return a.Length + b.Length == count;
        }
    }
}

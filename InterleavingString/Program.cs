using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterleavingString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsInterleave("aabcc", "dbbca", "aadbbbaccc"));
            Console.ReadLine();
        }
        
        public static bool IsInterleave(string s1, string s2, string s3)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s3.Contains(s1[i]))
                {
                    var temp = s3.IndexOf(s1[i]);
                    s3 = s3.Remove(temp,1);
                }
            }
            if (s2 != s3)
            {
                return false;
            }
            for (int i = 0; i < s2.Length; i++)
            {
                if (s3.Contains(s2[i]))
                {
                    var temp = s3.IndexOf(s2[i]);
                    s3 = s3.Remove(temp, 1);
                }
            }
            return s3.Length == 0;
        }

    }
}
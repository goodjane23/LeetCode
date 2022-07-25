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
            Console.WriteLine(IsInterleave("aabcc", "dbbca", "aadbbcbcac"));
            Console.ReadLine();
        }
        
        public static bool IsInterleave(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length)
            {
                return false;
            }
            var c1  = s1.OrderBy(p => p);
            var c2 = s2.OrderBy(p => p);            
            var c3 = s3.OrderBy(p => p);

            int count = 1;

            for (int i = 0; i < s3.Length; i++)
            {

                if (!String.IsNullOrEmpty(s1))
                {
                    if (s1.Contains(s3[i]))
                    {
                        var position = s1.IndexOf(s3[i]);
                        s1 = s1.Remove(position, 1);
                        count++;
                        continue;
                    }
                }

                if (!string.IsNullOrEmpty(s2))
                {
                    if (s2.Contains(s3[i]))
                    {
                        var position = s2.IndexOf(s3[i]);
                        s2 = s2.Remove(position, 1);
                        count++;
                        continue;
                    }
                }
            }

            if (!String.IsNullOrEmpty(s1) || !string.IsNullOrEmpty(s2))
                return false;
            return count == s3.Length;
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///A string s is called good if there are no two different characters in s that have the same frequency.
///Given a string s, return the minimum number of characters you need to delete to make s good.
///The frequency of a character in a string is the number of times it appears in the string. 
///For example, in the string "aab", the frequency of 'a' is 2, while the frequency of 'b' is 1.
/// </summary>


namespace MinDeletionsMakeCharacterFrequencies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinDeletions("ddbcce"));
            Console.ReadLine();
        }
        public static int MinDeletions(string s)
        {
            int counter = 1;
            var arrOfChar =  s.ToArray();
            List<int> countsOfRepeat = new List<int>();
            Array.Sort(arrOfChar);
            var temp = arrOfChar[0];
            for (int i = 1; i < arrOfChar.Length; i++)
            {
                if (temp == arrOfChar[i])
                    counter++;
                else
                {
                    countsOfRepeat.Add(counter);
                    temp = arrOfChar[i];
                    counter = 1;
                }
            }

            if (counter != 0)
                countsOfRepeat.Add(counter);
            int change = 0;

            countsOfRepeat.Sort();
            if (countsOfRepeat.Count() == countsOfRepeat.Distinct().Count())
            {
                return countsOfRepeat.Count() - countsOfRepeat.Distinct().Count();
            }
            else
            {
                while (!IsDistinct(countsOfRepeat))
                {
                    for (int i = 0; i < countsOfRepeat.Count(); i++)
                    {
                        if (countsOfRepeat[i] == 0) continue;
                        for (int j = ++i; j <= countsOfRepeat.Count()-1; j++)
                        {
                            if (countsOfRepeat[j] == 0) continue;
                            if (countsOfRepeat[j] == countsOfRepeat[i])
                            {
                                countsOfRepeat[j]--;
                                change++;

                            }
                            countsOfRepeat.Sort();
                        }
                    }
                }
            }            
            return change; 
        }

        public static bool IsDistinct(IEnumerable<int> colection)
        {
            List<int> listFromCollecion = colection.ToList();
            listFromCollecion.RemoveAll(x => x == 0);
            if (listFromCollecion.Count() == listFromCollecion.Distinct().Count())
                return true;
            return false;
               
        }
        
    }
}

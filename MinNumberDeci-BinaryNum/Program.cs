using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumberDeci_BinaryNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MinPartitions("82734"));
            Console.ReadLine();
        }
        public static int MinPartitions(string n)
        {
            int result = 0;
            char[] chars = n.ToCharArray();
            foreach (char ch in chars)
            {
                int.TryParse(ch.ToString(), out int max);
                if (result < max)
                    result = max;
            }
            return result;

        }
    }
}

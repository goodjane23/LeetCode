using System;

/// <summary>
/// A decimal number is called deci-binary if each of its digits is
/// either 0 or 1 without any leading zeros. For example, 101 and 1100 are deci-binary,
/// while 112 and 3001 are not.
/// Given a string n that represents a positive decimal integer, return the minimum number of 
/// positive deci-binary numbers needed so that they sum up to n.
/// </summary>


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

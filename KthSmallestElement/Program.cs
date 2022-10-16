using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//[[1,5,9],[10,11,13],[12,13,15]],
namespace KthSmallestElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[2][];
            matrix[0] = new int[] { 1, 2 };
            matrix[1] = new int[] { 1, 3 };
            KthSmallest(matrix, 2);
        }

        public static int KthSmallest(int[][] matrix, int k)
        {
            return 0;
        }
    }
}

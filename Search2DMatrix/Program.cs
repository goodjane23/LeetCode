using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search2DMatrix
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[5][];
            matrix[0] = new int[] { 1, 4, 7, 11, 15 };
            matrix[1] = new int[] { 2, 5, 8, 12, 19 };
            matrix[2] = new int[] { 3, 6, 9, 16, 22 };
            matrix[3] = new int[] { 10, 13, 14, 17, 24 };
            matrix[4] = new int[] { 18, 21, 23, 26, 30 };
            SearchMatrix(matrix, 5);
        }

        public static bool SearchMatrix(int[][] matrix, int target)
        {
  

            var x = Array.BinarySearch(matrix, target);
            if (x>=0)
            {
                return true;
            }
            return false;
        }
    }
}

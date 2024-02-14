using System.Linq;

//You are given an m x n integer matrix matrix with the following two properties:
//Each row is sorted in non-decreasing order.
//The first integer of each row is greater than the last integer of the previous row.
//Given an integer target, return true if target is in matrix or false otherwise.
//You must write a solution in O(log(m * n)) time complexity.

namespace Search2DMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[5][];
            matrix[0] = [1, 4, 7, 11, 15];
            matrix[1] = [2, 5, 8, 12, 19];
            matrix[2] = [3, 6, 9, 16, 22];
            matrix[3] = [10, 13, 14, 17, 24];
            matrix[4] = [18, 21, 23, 26, 30];
            SearchMatrix(matrix, 5);
        }

        public static bool SearchMatrix(int[][] matrix, int target)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i].Contains(target)) return true;
            }
            return false;
        }
        //or
        public bool SearchMatrix2(int[][] matrix, int target)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == target) return true;
                }
            }
            return false;
        }
    }
}

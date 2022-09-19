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
            matrix[1] = new int[] { 1, 3};
            KthSmallest(matrix, 2);
        }

        public static int KthSmallest(int[][] matrix, int k)
        {
            int result1 = 0;
            int result2 = 0;
            int count = 0;
            int size = 0;
            foreach (var item in matrix)
            {       
                size = item.Length;
                if (count + item.Length < k)
                    count += item.Length;
                    
                else
                    for (int i = 0; i < item.Length; i++)
                    {
                        count++;
                        if (count == k)
                        {
                            result1 = item[i];
                        }
                    }
            }
            count = 0;

            bool res = false;
            for (int j = 0; j < matrix.Length; j++)
            {
                if (res)
                    break;
                for (int i = 0; i < size; i++)
                {
                    if (matrix[i][j] + count < k)
                    {
                        count += size;
                    }
                    else
                    {
                        for (int v = 0; v < size; v++)
                        {
                            result2 = matrix[i][j];
                            res = true;
                            break;
                        }
                       
                    }

                }
            }

          
            return Math.Min(result1,result2);
        }
    }
}

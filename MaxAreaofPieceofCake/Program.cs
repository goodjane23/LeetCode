using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///<summary>
///You are given a rectangular cake of size h x w and two arrays of integers horizontalCuts and verticalCuts where:
///horizontalCuts[i] is the distance from the top of the rectangular cake to the ith horizontal cut and similarly, and
///verticalCuts[j] is the distance from the left of the rectangular cake to the jth vertical cut.
///Return the maximum area of a piece of cake after you cut at each horizontal and vertical position 
///provided in the arrays horizontalCuts and verticalCuts. Since the answer can be a large number, return this modulo 109 + 7.
/// </summary>

namespace MaxAreaofPieceofCake
{

    internal class Program
    {
        static void Main(string[] args)
        {
            MaxArea(1000000000, 1000000000, new int[] { 2 }, new int[] { 2 });
        }

        public static int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts)
        {
            
            long maxHorizontal = FindMax(horizontalCuts, h);
            long maxVertical = FindMax(verticalCuts, w);
            return (int)((int) maxHorizontal*maxVertical % 1000000007);

        }
        public static int FindMax(int[] arr, int lngth)
        {
            Array.Resize(ref arr, arr.Length+2);
            arr[arr.Length - 1] = lngth;
            
            Array.Sort(arr);
            int max = 0;
            for (int i = arr.Length-1; i > 0; i--)
            {
                var temp = arr[i] - arr[i - 1];
                if (temp > max)
                    max = temp;
            }
            return max;
        }

    }
}

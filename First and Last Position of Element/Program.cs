using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_and_Last_Position_of_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SearchRange(new int[] { 3,3,4,5,6,8,8,9 }, 10);
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2] { -1, -1 };
            
            var index = Array.IndexOf(nums, target);
            var index2 = Array.LastIndexOf(nums, target);   
            
            result[0] = index;
            result[1] = index2;
            return result;

        }
    }
}

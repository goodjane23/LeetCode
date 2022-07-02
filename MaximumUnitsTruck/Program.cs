using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///You are assigned to put some amount of boxes onto one truck. You are given a 2D array boxTypes, 
///where boxTypes[i] = [numberOfBoxesi, numberOfUnitsPerBoxi]:
///     ()numberOfBoxesi is the number of boxes of type i.
///     numberOfUnitsPerBoxi is the number of units in each box of the type i.
/// You are also given an integer truckSize, which is the maximum number of boxes that can be put on the truck. 
/// You can choose any boxes to put on the truck as long as the number of boxes does not exceed truckSize.
/// Return the maximum total number of units that can be put on the truck.
///</summary>
namespace MaximumUnitsTruck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] boxTypes = new int[3][];
            boxTypes[0] = new int[2] { 1,3} ;
            boxTypes[1] = new int[2] { 2,2};
            boxTypes[2] = new int[2] {3,1};

            Console.WriteLine(MaximumUnits( boxTypes, 4 ));
        }
        public static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            int result = 0;
            int max = 0;
            int indexMax;
            for (int i = 0; i < boxTypes.Length; i++)
            {              
                for (int j = 0; j < 2; j++)
                {
                    if (boxTypes[i][1] > max)
                    {
                        max = boxTypes[i][1];
                        indexMax = boxTypes[i][j];
                    }  

                }
            }
            return 0;

        }

        public static void FindMax()
        {
            int max = 0;
            
        }
    }
}


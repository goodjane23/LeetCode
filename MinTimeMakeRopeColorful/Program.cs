/// <summary>
/// Alice has n balloons arranged on a rope. You are given a 0-indexed string colors where colors[i] 
/// is the color of the ith balloon.
/// Alice wants the rope to be colorful. 
/// She does not want two consecutive balloons to be of the same color, so she asks Bob for help. 
/// Bob can remove some balloons from the rope to make it colorful. You are given a 0-indexed integer array 
/// neededTime where neededTime[i] is the time (in seconds) that Bob needs to remove the ith balloon from the rope.
/// Return the minimum time Bob needs to make the rope colorful.
/// </summary>
internal class Program
{
    private static void Main(string[] args)
    {
        int[] neededTime = new int[] { 1, 2, 3, 4, 1 };
        MinCost("aabaa", neededTime);
    }

    public static int MinCost(string colors, int[] neededTime)
    {
        int result = 0;
        int indexRepeat;
        string vasp = colors;
     
        while (!IsCheckRope(colors, out indexRepeat))
        {
            result += neededTime[indexRepeat];
            vasp = colors.Remove(indexRepeat, 1);
        }
      
        return result;
    }

    public static bool IsCheckRope(string colors, out int indexRepeat)
    {
        indexRepeat = 0;
        for (int i = 0; i < colors.Length-1; i++)
        {
            if (colors[i] == colors[i + 1])
            {
                indexRepeat = i;
                return false;
            }
                
        }
        return true;
    }
}

using System.Text;

/// <summary>
/// You are given a positive integer num consisting only of digits 6 and 9.
/// Return the maximum number you can get by changing at most one digit (6 becomes 9, and 9 becomes 6).
/// </summary>

class Program
{
    public static void Main(string[] args)
    {
        Maximum69Number(6996);
    }
    
    public static int Maximum69Number (int num)
    {
        StringBuilder sb = new StringBuilder(num.ToString());
        for (int i = 0; i < sb.Length; i++)
        {
            if (sb[i] == '6')
            {
                sb[i] = '9';
                return Int32.Parse(sb.ToString());
            }
        }
        return num;
    }
}
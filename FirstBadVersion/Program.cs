///<summary>
///You are a product manager and currently leading a team to develop a new product. Unfortunately, the latest version of
/// your product fails the quality check.
/// Since each version is developed based on the previous version, all the versions after a bad version are also bad.
/// Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, which causes all the following ones to be bad.
/// You are given an API bool isBadVersion(version) which returns whether version is bad. Implement a function to find the
/// first bad version. You should minimize the number of calls to the API.
/// </summary>
namespace FirstBadVersion;

internal class Program
{
    static void Main(string[] args)
    {
        FirstBadVersion(6);
    }

    private static int FirstBadVersion(int n)
    {
        var startPoint = 0;
        var amount = n;
        while(startPoint <= amount)
        {
            var mid = startPoint + (amount - startPoint) / 2;
            
            if(IsBadVersion(mid))
            {
                if(mid - 1 >= 0 && !IsBadVersion(mid - 1)) return mid;
                amount = mid - 1;
            }
            else startPoint = mid + 1;
        }
        return 0;
    }

    private static bool IsBadVersion(int i)
    {
        return true;
    }
}
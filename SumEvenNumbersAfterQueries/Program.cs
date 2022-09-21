
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
    {
        int[] answer = new int[nums.Length];
        int evenSum = nums.Where(x => x % 2 == 0).Sum();
        int index = 0;

        foreach (var query in queries)
        {
            var originalNum = nums[query[1]];
            var changedNum = nums[query[1]] += query[0];

            if (changedNum % 2 == 0)
            {
                if (originalNum % 2 == 0)
                    evenSum += query[0];
                else
                    evenSum += changedNum;
            }
            else
            {
                if (originalNum % 2 == 0)
                    evenSum -= originalNum;
            }
            answer[index++] = evenSum;
        }
        return answer;
    }
    
}
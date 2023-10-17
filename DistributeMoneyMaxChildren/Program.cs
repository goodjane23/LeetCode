/// <summary>
/// You are given an integer money denoting the amount of money (in dollars) that you have and another 
/// integer children denoting the number of children that you must distribute the money to.
/// You have to distribute the money according to the following rules:
/// All money must be distributed.
/// Everyone must receive at least 1 dollar.
/// Nobody receives 4 dollars.
/// Return the maximum number of children who may receive exactly 8 dollars
/// if you distribute the money according to the aforementioned rules. 
/// If there is no way to distribute the money, return -1.
/// </summary>

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine($"Result is: {DistMoney(20,3)}");
        Console.ReadLine();
    }

    public static int DistMoney(int money, int children)
    {
        var maxCountChildren = money / 8;

        return -1;
    }
}
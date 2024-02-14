
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        //[2,4,3], l2 = [5,6,4]
        ListNode listNode1 = new (2, new (4, new(3)));
        ListNode listNode2 = new (5, new (6, new(4)));
        AddTwoNumbers(listNode2, listNode1);
        Console.ReadLine();
    }

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode();
        var x1 = GetList(l1);
        var x2 = GetList(l2);

        var y1 = GetInt(x1);
        var y2 = GetInt(x2);

        var sum = (y1 + y2).ToString();

        //Create listnode
        for (int i = sum.Length-1; i >= 0; i--)
        {
            
        }

        return result;
    }

    private static List<int> GetList(ListNode l1)
    {
        List<int> ints = [l1.val];
        var temp = l1.next;
        while (temp is not null)
        {
            ints.Add(temp.val);
            temp = temp.next;
        }
        return ints;
    }

    private static int GetInt(List<int> ints)
    {
        int n1 = 0;
        for (int i = 0; i < ints.Count; i++)
        {
            var ten = (int)Math.Pow(10, i);
            var num1 = ints[i] * ten;
            n1 += num1;
        }
        return n1;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
 }

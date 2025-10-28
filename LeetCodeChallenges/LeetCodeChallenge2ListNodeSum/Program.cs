namespace LeetCodeChallenge2ListNodeSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test case 1
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            ListNode result1 = AddTwoNumbers(l1, l2);
            PrintList(result1); // Saída: 7 -> 0 -> 8

            // Test case 2
            ListNode l3 = new ListNode(0);
            ListNode l4 = new ListNode(0);
            ListNode result2 = AddTwoNumbers(l3, l4);
            PrintList(result2); // Saída: 0

            // Test case 3
            ListNode l5 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9,
                            new ListNode(9, new ListNode(9, new ListNode(9)))))));
            ListNode l6 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            ListNode result3 = AddTwoNumbers(l5, l6);
            PrintList(result3); // Saída: 8 -> 9 -> 9 -> 9 -> 0 -> 0 -> 0 -> 1
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode l3 = new ListNode();
            ListNode actual = l3;
            int value = 0;
            int carry = 0;

            while (l1 != null || l2 != null || carry > 0)
            {
                int l1val = (l1 != null) ? l1.val : 0;
                int l2val = (l2 != null) ? l2.val : 0;

                int sum = l1val + l2val + carry;

                value = sum % 10;
                carry = sum / 10;

                actual.next = new ListNode(value);
                actual = actual.next;

                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }



            return l3.next;

        }

        public static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val);
                if (node.next != null)
                    Console.Write(" -> ");
                node = node.next;
            }
            Console.WriteLine();
        }


    }
}

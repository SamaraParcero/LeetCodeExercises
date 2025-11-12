using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeChallenge21
{
    internal class MergeTwoSortedLists
    {

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

        //Minha solução
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode list = new ListNode(0);
            ListNode tail = list;

            while (list1 != null && list2 != null)
            {

                if (list1.val > list2.val)
                {
                    tail.next = list2;
                    list2 = list2.next;
                }
                else if (list1.val < list2.val)
                {
                    tail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    tail.next = list1;
                    list1 = list1.next;
                    tail = tail.next;
                    tail.next = list2;
                    list2 = list2.next;
                }

                tail = tail.next;
            }

            if (list1 != null)
            {
                tail.next = list1;
            }
            else
            {
                tail.next = list2;
            }


            return list.next;
        }


        //Solução simples
        public ListNode MergeTwoLists2(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            if (list1.val < list2.val)
            {
                list1.next = MergeTwoLists2(list1.next, list2);
                return list1;
            }
            else
            {
                list2.next = MergeTwoLists2(list1, list2.next);
                return list2;
            }
        }
    }
}

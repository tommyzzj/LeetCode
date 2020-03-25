using LeetCode.DataStructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class No206
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode curr = head;
            ListNode temp;
            while (curr != null)
            {
                temp = curr.next;
                curr.next = prev;

                prev = curr;
                curr = temp;
            }

            return prev;
        }
    }
}

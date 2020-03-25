using LeetCode.DataStructure;
using System;

namespace LeetCode
{
    public class No2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = p?.val ?? 0;
                int y = q?.val ?? 0;
                int sum = x + y + carry;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                p = p?.next;
                q = q?.next;
            }

            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }

            return dummyHead.next;
        }
    }
}

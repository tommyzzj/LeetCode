using LeetCode.DataStructure;
using Microsoft.VisualBasic;

namespace LeetCode
{
    public class No0019
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode first = head;
            ListNode second = dummy;

            for (int i = 0; i < n; ++i)
            {
                first = first.next;
            }

            while (first != null)
            {
                first = first.next;
                second = second.next;
            }

            second.next = second.next.next;
            ListNode ans = dummy.next;
            return ans;
        }
    }
}
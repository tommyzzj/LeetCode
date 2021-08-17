using LeetCode.DataStructure;

namespace LeetCode
{
    public class No0237
    {
        public void DeleteNode(ListNode node)
        {
            node.next = node.next.next;
            node.val = node.next.val;
        }
    }
}
using System.Collections.Generic;
using LeetCode.DataStructure;

namespace LeetCode
{
    /*
    输入：head = [1,3,2]
    输出：[2,3,1]

    * Definition for singly-linked list.
    * public class ListNode {
    *     public int val;
    *     public ListNode next;
    *     public ListNode(int x) { val = x; }
    * }
    */
    public class NoLc06
    {
        List<int> tmp = new List<int>();

        public int[] ReversePrint(ListNode head)
        {
            Recursion(head);

            int[] res = new int[tmp.ToArray().Length];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = tmp[i];
            }
            return res;
        }

        public void Recursion(ListNode head){
            if(head == null) return;
            Recursion(head.next);
            tmp.Add(head.val);
        }
    }
}

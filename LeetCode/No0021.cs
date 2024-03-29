﻿using LeetCode.DataStructure;
using System;

namespace LeetCode
{
    class No0021
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            //if (l1 == null) return l2;
            //if (l2 == null) return l1;
            //if (l1.val < l2.val)
            //{
            //    l1.next = MergeTwoLists(l1.next, l2);
            //    return l1;
            //}
            //else
            //{
            //    l2.next = MergeTwoLists(l2.next, l1);
            //    return l2;
            //}

            ListNode dummy = new ListNode(0);
            ListNode head = dummy;
            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    head.next = new ListNode(l1.val);
                    l1 = l1.next;
                }
                else
                {
                    head.next = new ListNode(l2.val);
                    l2 = l2.next;
                }

                head = head.next;
            }

            if (l1 != null) head.next = l1;
            if (l2 != null) head.next = l2;
            return dummy.next;
        }
    }
}

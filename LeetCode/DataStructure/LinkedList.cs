using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace LeetCode.DataStructure
{
    public class LinkedList
    {
        public readonly ListNode Head;
        private int _size = 0;

        public LinkedList()
        {
            Head = new ListNode(0);
        }

        public int Get(int index)
        {
            // if index is invalid
            if (index < 0 || index >= _size) return -1;

            ListNode curr = Head;
            // index steps needed 
            // to move from sentinel node to wanted index
            for (int i = 0; i < index + 1; ++i) curr = curr.next;
            return curr.val;
        }

        public void AddAtTail(int val)
        {
            AddAtIndex(_size, val);
        }

        public void AddAtHead(int val)
        {
            AddAtIndex(0, val);
        }

        private void AddAtIndex(int index, int val)
        {
            if (index > _size) return;

            // [so weird] If index is negative, 
            // the node will be inserted at the head of the list.
            if (index < 0) index = 0;

            ++_size;
            // find predecessor of the node to be added
            ListNode pred = Head;
            for (int i = 0; i < index; ++i)
            {
                pred = pred.next;
            }

            // node to be added
            ListNode toAdd = new ListNode(val);
            // insertion itself
            toAdd.next = pred.next;
            pred.next = toAdd;
        }
    }
}
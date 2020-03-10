using System;
using System.Threading;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var l1 = new ListNode(2) { next = new ListNode(4) { next = new ListNode(6) } };
            //var l2 = new ListNode(1) { next = new ListNode(3) { next = new ListNode(5) } };

            //var solution = new No206();

            //var result = solution.ReverseList(l1);

            //PrintListNode(result);
            //var solution = new Interview10_01();
            //var A = new int[] { 1, 3, 5, 0, 0, 0 };
            //var B = new int[] { 2, 4, 6 };
            //solution.Merge(A, 3, B, 3);
            //foreach (var num in A)
            //{
            //    Console.WriteLine(num);
            //}
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: Creating the Child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
            Console.ReadKey();
        }

        public static void CallToChildThread()
        {
            Console.WriteLine("Child thread starts");
        }

        public static void PrintListNode(ListNode listNode)
        {
            Console.WriteLine(listNode.val);
            if (listNode.next != null)
            {
                PrintListNode(listNode.next);
            }
        }
    }
}

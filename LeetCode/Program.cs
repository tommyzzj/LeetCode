using System;
using System.Threading;
using LeetCode.DataStructure;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var test = new int[] {3, 2, 3};
            var l1 = new ListNode(2);
            var l2 = new ListNode(1);
            var l3 = new ListNode(0);

            l1.next = l2;
            l2.next = l3;
            var result = new NoLc06();
            var a = result.ReversePrint(l1);

            Console.WriteLine(result.ReversePrint(l1));
        }
    }
}

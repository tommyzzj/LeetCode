using System;
using System.Threading;
using LeetCode.DataStructure;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[] { 2, 2, 1 };
            int[] n2 = new int[] { 0,4, 1, 2,0, 1, 2,3,5,5,3 };

            var result = new No136();

            Console.WriteLine(result.SingleNumber(n2));
        }
    }
}

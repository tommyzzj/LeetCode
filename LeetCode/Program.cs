using System;
using System.Threading;
using LeetCode.DataStructure;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[] { 1, 1,1 };
            int[] n2 = new int[] { 3, 2,5 };

            var result = new No70();

            Console.WriteLine(result.ClimbStairs(5));
        }
    }
}

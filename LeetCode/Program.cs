using System;
using System.Threading;
using LeetCode.DataStructure;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int[] n2 = new int[] { 1,2,3,4,5,6,7};
            int[] n3 = new int[] { 0 };

            var result = new No0189();
            result.Rotate(n2,3);
            foreach (var n in n2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
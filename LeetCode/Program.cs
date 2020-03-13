using System;
using System.Threading;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var test = new int[] {3, 2, 3};
            var result = new No169();

            Console.WriteLine(result.MajorityElement(test));
        }
    }
}

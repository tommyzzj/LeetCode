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
            int[] pole = new int[] { 4, 2, 2, 3, 1, 4, 7, 8, 6, 9 };
            int[] n2 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int[] n3 = new int[] { 0 };
            string test = "loveleetcode";

            var result = new MagnitudePole();
            var output = result.FindMagnitudePole(pole);
            Console.WriteLine(output);
        }
    }
}
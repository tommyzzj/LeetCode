﻿using System;
using System.Threading;
using LeetCode.DataStructure;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[] { 2, 2, 1 };
            int[] n2 = new int[] { 0, 4, 1, 2, 0, 1 };
            int[] n3 = new int[] { 0 };

            var result = new No168();
            var output = result.ConvertToTitle(701);
            Console.WriteLine(output);
        }
    }
}

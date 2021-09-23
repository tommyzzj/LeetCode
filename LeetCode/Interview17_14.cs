using System;
using System.Linq;

namespace LeetCode
{
    public class Interview17_14
    {
        public class Solution {
            public int[] SmallestK(int[] arr, int k) {
                Array.Sort(arr);
                return arr.Take(k).ToArray();
            }
        }
    }
}
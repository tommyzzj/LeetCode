using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace LeetCode
{
    public class NoLc53
    {
        public int Search(int[] nums, int target)
        {
            return nums.Count(num => num == target);
        }
    }
}
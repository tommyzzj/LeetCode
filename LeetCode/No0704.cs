using System;
using System.Linq;

namespace LeetCode
{
    public class No0704
    {
        public int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                int middle = (left + right) / 2;
                int mid = nums[middle];
                if (mid == target)
                {
                    return middle;
                }
                if (mid > target)
                {
                    right = middle - 1;
                }
                else
                {
                    left = middle + 1;
                }
            }

            return -1;
        }
    }
}
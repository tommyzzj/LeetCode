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
            while (left < right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }
                if (nums[mid] > target)
                {
                    right = mid - 1;  // (0+5)/2 = 2 需要-1
                }
                if (nums[mid] < target)
                {
                    left = mid + 1; // (0+5)/2 = 2 需要+1
                }
            }
            return -1;
        }
    }
}
using System;
using System.Linq;

namespace LeetCode
{
    public class No0154
    {
        public int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (nums[right] > nums[mid])
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return nums[left];
        }
    }
}
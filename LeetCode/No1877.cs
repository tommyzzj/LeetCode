using System;

namespace LeetCode
{
    public class No1877
    {
        public int MinPairSum(int[] nums)
        {
            int n = nums.Length;
            int result = 0;
            Array.Sort(nums);
            for (int i = 0; i < n/2; i++)
            {
                result = Math.Max(result, nums[i] + nums[n - 1 - i]);
            }

            return result;
        }
    }
}
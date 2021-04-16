using System;

namespace LeetCode
{
    public class No198
    {
        public int Rob(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int length = nums.Length;
            if (length == 1)
            {
                return nums[0];
            }

            // int[] dp = new int[length];
            // dp[0] = nums[0];
            // dp[1] = Math.Max(nums[0], nums[1]);
            // for (int i = 2; i < length; i++)
            // {
            //     dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
            // }
            // return dp[length - 1];

            int first = nums[0], second = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < length; i++)
            {
                int temp = second;
                second = Math.Max(first + nums[i], second);
                first = temp;
            }

            return second;
        }
    }
}
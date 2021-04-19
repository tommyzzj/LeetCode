using System;

namespace LeetCode
{
    public class No27
    {
        public int RemoveElement(int[] nums, int val)
        {
            int slowIndex = 0;
            for (int fastIndex = 0; fastIndex < nums.Length; fastIndex++)
            {
                if (val != nums[fastIndex])
                {
                    nums[slowIndex++] = nums[fastIndex];
                }
            }

            return slowIndex;
        }
    }
}
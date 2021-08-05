using System;

namespace LeetCode
{
    class No0026
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            
            int slowIndex = 0;
            for (int fastIndex = 1; fastIndex < nums.Length; fastIndex++)
            {
                if (nums[fastIndex] != nums[slowIndex])
                {
                    nums[++slowIndex] = nums[fastIndex];
                }
            }

            return slowIndex + 1;
        }
    }
}

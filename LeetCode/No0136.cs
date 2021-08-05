using System;
namespace LeetCode
{
    public class No0136
    {
        public int SingleNumber(int[] nums)
        {
            if (nums.Length != 1)
            {
                Array.Sort(nums);
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i == nums.Length - 1)
                    {
                        return nums[i];
                    }
                    if (nums[i] == nums[i + 1])
                    {
                        i++;
                        continue;
                    }
                    else
                    {
                        return nums[i];
                    }
                }
            }
            
            return -1;
        }
    }
}

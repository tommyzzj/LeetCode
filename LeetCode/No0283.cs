using System;
namespace LeetCode
{
    public class No0283
    {
        public void MoveZeroes(int[] nums)
        {
            if (nums == null)
                return;

            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                    j++;
                }
            }
        }
    }
}

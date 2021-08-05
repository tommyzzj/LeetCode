namespace LeetCode
{
    public class No0494
    {
        int count = 0;

        public int FindTargetSumWays(int[] nums, int target) {
            Backtrack(nums, target, 0,0);
            return count;
        }

        public void Backtrack(int[] nums, int target, int index, int sum) {
            if (index == nums.Length)
            {
                if (sum==target)
                {
                    count++;
                }
            }
            else
            {
                Backtrack(nums, target, index + 1, sum + nums[index]);
                Backtrack(nums, target, index + 1, sum - nums[index]);
            }
        }
    }
}
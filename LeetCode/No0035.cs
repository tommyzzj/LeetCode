namespace LeetCode
{
    public class No0035
    {
        public int SearchInsert(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            if (target > nums[right])
            {
                return right;
            }

            if (target < nums[left])
            {
                return left;
            }
            
            while (left <= right)
            {
                if (left == right)
                {
                    return left;
                }
                int mid = (right + left) / 2;
                if (nums[mid] == target)
                {
                    return mid;
                }

                if (nums[mid]> target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }

            return 0;
        }
    }
}
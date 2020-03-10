namespace LeetCode
{
    class No26
    {
        public int RemoveDuplicates(int[] nums)
        {
            // My Solution - Wrong
            // var hashMap = new HashSet<int>();
               
            // foreach (var val in nums)
            // {
            //     hashMap.Add(val);
            // }
               
            // return hashMap.Count;

            if (nums.Length == 0)
                return 0;
            int i = 0;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j] != nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}

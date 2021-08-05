using System;
using System.Collections.Generic;
using System.Globalization;

namespace LeetCode
{
    public class No0217
    {
        public bool ContainsDuplicate(int[] nums)
        {
            #region Solution 1

            // Array.Sort(nums);
            // for (int i = 1; i < nums.Length; i++)
            // {
            //     if (nums[i] == nums[i - 1])
            //     {
            //         return true;
            //     }
            // }
            //
            // return false;

            #endregion
            
            #region Solution 2

            HashSet<int> hs = new HashSet<int>();
            foreach (int n in nums)
            {
                if (!hs.Add(n))
                {
                    return true;
                }
            }

            return false;

            #endregion
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace LeetCode
{
    internal class No0001
    {
        public int[] TwoSum(int[] nums, int target)
        {
            #region Brute Array

            //for (var i = 0; i < nums.Length; i++)
            //{
            //    for (var j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            return new[] { i, j };
            //        }
            //    }
            //}

            #endregion

            #region Two Pass Hash Table

            //var map = new Dictionary<int, int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    map.Add(nums[i], i);
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int complement = target - nums[i];
            //    if (map.ContainsKey(complement) && map.GetValueOrDefault(complement) != i)
            //    {
            //        return new [] { i, map.GetValueOrDefault(complement) };
            //    }
            //}

            #endregion

            #region One Pass Hash Table

            var map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new [] { map.GetValueOrDefault(complement), i };
                }
                map.TryAdd(nums[i], i);
            }

            #endregion


            throw new ArgumentException("No two sum solution");
        }
    }
}

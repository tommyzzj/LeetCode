using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

namespace LeetCode
{
    // 169. Majority Element
    // Given an array of size n, find the majority element.The majority element is the element that appears more than ⌊ n/2 ⌋ times.

    // You may assume that the array is non-empty and the majority element always exist in the array.

    // Example 1:

    // Input: [3,2,3]
    // Output: 3
    // Example 2:


    // Input: [2,2,1,1,1,2,2]
    // Output: 2
    class No169
    {
        public int MajorityElement(int[] nums)
        {
            var major = 0;
            var majorKey = 0;
            var counts = countNums(nums);

            foreach (var count in counts)
            {
                if (count.Value >=major)
                {
                    major = count.Value;
                    majorKey = count.Key;
                }
            }

            return majorKey;
        }

        private Dictionary<int, int> countNums(int[] nums)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (!counts.TryAdd(num, 1))
                {
                    counts[num]++;
                }
            }

            return counts;
        }
    }
}

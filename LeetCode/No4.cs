using System;
using System.Linq;
namespace LeetCode
{
    public class No4
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Count() == 0 && nums2.Count() == 0)
            {
                return 0;
            }

            var merged = nums1.Concat(nums2).ToArray();
            Array.Sort(merged);

            var length = merged.Length;

            if (length % 2 == 0)
            {
                return ((double)merged[length / 2 - 1] + (double)merged[length / 2]) / 2;
            }
            else
            {
                var inter = (int)Math.Ceiling(length / 2.0);
                return merged[inter - 1];
            }
        }
    }
}

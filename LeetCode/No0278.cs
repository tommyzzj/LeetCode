using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    internal class No0278
    {
        public class Solution : VersionControl
        {
            public int FirstBadVersion(int n)
            {
                int left = 1, right = n;
                while (left < right)
                { // 循环直至区间左右端点相同
                    int mid = left + (right - left) / 2; // 防止计算时溢出
                    if (IsBadVersion(mid))
                    {
                        right = mid; // 答案在区间 [left, mid] 中
                    }
                    else
                    {
                        left = mid + 1; // 答案在区间 [mid+1, right] 中
                    }
                }
                // 此时有 left == right，区间缩为一个点，即为答案
                return left;
            }
        }
    }

    class VersionControl
    {
        public bool IsBadVersion(int version)
        {
            if (version >= 4)
            {
                return true;
            }
            return false;
        }
    }
}

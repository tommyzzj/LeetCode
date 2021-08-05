using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class No0003
    {
        public int LengthOfLongestSubstring(string s)
        {
            var occ = new HashSet<Char>();
            int n = s.Length;
            int rk = -1, ans = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i != 0)
                {
                    occ.Remove(s[i - 1]);
                }

                while (rk + 1 < n && !occ.Contains(s[rk + 1]))
                {
                    occ.Add(s[rk + 1]);
                    ++rk;
                }
                ans = Math.Max(ans, rk - i + 1);
            }

            return ans;
        }
    }
}

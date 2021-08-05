using System;

namespace LeetCode
{
    public class No0122
    {
        public int MaxProfit(int[] prices)
        {
            int ans = 0;
            int n = prices.Length;
            for (int i = 1; i < n; ++i) {
                ans += Math.Max(0, prices[i] - prices[i - 1]);
            }
            return ans;
        }
    }
}
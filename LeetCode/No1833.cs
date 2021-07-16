using System;

namespace LeetCode
{
    public class No1833
    {
        public int MaxIceCream(int[] costs, int coins)
        {
            int n = costs.Length;
            Array.Sort(costs);
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                if (coins >= costs[i])
                {
                    ans++;
                    coins -= costs[i];
                }
            }

            return ans;
        }
    }
}
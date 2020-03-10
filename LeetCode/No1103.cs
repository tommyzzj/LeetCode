using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class No1103
    {
        public int[] DistributeCandies(int candies, int num_people)
        {
            #region 超时………………

            //var ans = new int[num_people];
            //var index = 0;
            //var remain = candies;

            //while (remain - index >= 0)
            //{
            //    ans[index % num_people] += index;
            //    remain = remain - index;
            //    index++;
            //}

            //ans[index % num_people] += remain;

            //return ans;

            #endregion

            #region 题解

            int[] ans = new int[num_people];
            int i = 0;
            while (candies != 0)
            {
                ans[i % num_people] += Math.Min(candies, i + 1);
                candies -= Math.Min(candies, i + 1);
                i += 1;
            }

            return ans;

            #endregion
        }
    }
}

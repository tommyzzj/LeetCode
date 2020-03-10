﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class No121
    {
        public int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;
            foreach (var price in prices)
            {
                if (price < minPrice)
                {
                    minPrice = price;
                }

                if (price - minPrice > maxProfit)
                {
                    maxProfit = price - minPrice;
                }
            }
            return maxProfit;
        }
    }
}

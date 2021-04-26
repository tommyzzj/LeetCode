using System;

namespace LeetCode
{
    public class No1011
    {
        public int ShipWithinDays(int[] weights, int D) {
            int l = Max(weights), r = Sum(weights);
            while(l < r)
            {
                int mid = l + (r - l) / 2;
                int temp = 0, day = 1;
                for(int i = 0; i < weights.Length; i++)
                {
                    temp += weights[i];
                    if(temp > mid)
                    {
                        day += 1;
                        temp = weights[i];
                    }
                }
                if(day > D)
                    l = mid + 1;
                else
                    r = mid;
            }
            return l;
        }

        public int Max(int[] weights)
        {
            int a = weights[0];
            for(int i = 1; i < weights.Length; i++)
            {
                if(weights[i] > a)
                    a = weights[i];
            }
            return a;
        }

        public int Sum(int[] weights)
        {
            int a = weights[0];
            for(int i = 1; i < weights.Length; i++)
            {
                a +=weights[i];
            }
            return a;
        }
    }
}
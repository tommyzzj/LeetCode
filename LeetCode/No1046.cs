using System;
namespace LeetCode
{
    public class No1046
    {
        public int LastStoneWeight(int[] stones)
        {
            if (stones.Length == 2)
            {
                return Math.Abs(stones[0] - stones[1]);
            }
            if (stones.Length == 1)
            {
                return stones[0];
            }
            Array.Sort(stones);
            if (stones[stones.Length - 3] == 0)
            {
                return stones[stones.Length - 1] - stones[stones.Length - 2];
            }
            stones[stones.Length - 1] = stones[stones.Length - 1] - stones[stones.Length - 2];
            stones[stones.Length - 2] = 0;

            return LastStoneWeight(stones);
        }
    }
}

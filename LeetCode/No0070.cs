using System;
namespace LeetCode
{
    public class No0070
    {
        public int ClimbStairs(int n)
        {
            var sqrt5 = Math.Sqrt(5);

            var result = (Math.Pow((1 + sqrt5) / 2, n + 1) - Math.Pow((1 - sqrt5) / 2, n + 1)) / sqrt5;

            return (int)result;
        }
    }
}

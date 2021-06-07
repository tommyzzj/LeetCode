using System;
using System.IO.Pipes;
using System.Runtime.Serialization;

namespace LeetCode
{
    public class No1486
    {
        public int XorOperation(int n, int start)
        {
            int ans = 0;
            for (int i = 0; i < n; i++)
            {
                ans ^= (start + i * 2);
            }

            return ans;
        }
    }
}
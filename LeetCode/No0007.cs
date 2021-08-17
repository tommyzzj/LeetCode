using System;

namespace LeetCode
{
    public class No0007
    {
        public int Reverse(int x)
        {
            int rev = 0;
            while (x != 0) {
                if (rev < int.MinValue / 10 || rev > int.MaxValue / 10) {
                    return 0;
                }
                int digit = x % 10;
                x /= 10;
                rev = rev * 10 + digit;
            }
            return rev;
        }
    }
}
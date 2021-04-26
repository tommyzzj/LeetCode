using System;

namespace LeetCode
{
    public class No28
    {
        public int StrStr(string haystack, string needle)
        {
            int n = haystack.Length, m = needle.Length;
            for (int i = 0; i + m <= n; i++)
            {
                bool flag = true;
                for (int j = 0; j < m; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
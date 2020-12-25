using System;
namespace LeetCode
{
    public class No136
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int index = s.Length - 1;
            int count = 0;

            for (int i = g.Length - 1; i >= 0; i--)
            {
                if (index >= 0 && s[index] >= g[i])
                {
                    count++;
                    index--;
                }
            }
            return count;
        }
    }
}

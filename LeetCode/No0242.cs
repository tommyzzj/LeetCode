using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace LeetCode
{
    public class No0242
    {
        public bool IsAnagram(string s, string t)
        {
            char[] cs = s.ToCharArray();
            char[] ct = t.ToCharArray();
            int[] map = new int[26];

            foreach (char c in cs)
            {
                map[c - 'a']++;
            }

            foreach (char c in ct)
            {
                map[c - 'a']--;
            }

            foreach (int i in map)
            {
                if (i!=0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
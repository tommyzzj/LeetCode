using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class No0387
    {
        public int FirstUniqChar(string s)
        {
            var dictionary = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (!dictionary.TryAdd(ch, 1))
                {
                    dictionary[ch] ++;
                }
            }

            for (int i = 0; i < s.Length; i++)
            {
                char ch = s[i];
                if (dictionary[ch] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
using System;
using System.Text;

namespace LeetCode
{
    public class NoLc05
    {
        public string ReplaceSpace(string s)
        {
            StringBuilder res = new StringBuilder();
            foreach (char c in s)
            {
                if (c == ' ')
                {
                    res.Append("%20");
                }
                else
                {
                    res.Append(c);
                }
            }
            return res.ToString();
        }
    }
}

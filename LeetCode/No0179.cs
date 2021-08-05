using System;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class No0179
    {
        public string LargestNumber(int[] nums)
        {
            string[] ss = new string[nums.Length];
            int i = 0;
            foreach (int num in nums)
            {
                ss[i++] = "" + num;
            }
            Array.Sort(ss, (a, b) =>
            {
                string sa = a + b, sb = b + a;
                return sb.CompareTo(sa);
            });
            StringBuilder sb = new StringBuilder();
            foreach (string s in ss) sb.Append(s);
            int len = sb.Length;
            int k = 0;
            while (k < len-1 && sb[k] == '0') k++;
            return sb.ToString(k,len-k);
        }
    }
}
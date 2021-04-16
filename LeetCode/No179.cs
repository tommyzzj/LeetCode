using System;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class No179
    {
        public string LargestNumber(int[] nums)
        {
            var stringBuilder = new StringBuilder();
            foreach (var num in nums)
            {
                stringBuilder.Append(num);
            }
            return stringBuilder.ToString();
        }
    }
}
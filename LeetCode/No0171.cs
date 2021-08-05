using System;
using System.ComponentModel.DataAnnotations;

namespace LeetCode
{
    public class No0171
    {
        public int TitleToNumber(string columnTitle)
        {
            int result = 0;
            for (int i = 0; i < columnTitle.Length; i++)
            {
                int k = columnTitle[i] - 'A' + 1;
                result += k * (int)Math.Pow(26, columnTitle.Length - i - 1);
            }
            return result;
        }
    }
}
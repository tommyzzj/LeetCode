using System;
using System.Text;

namespace LeetCode
{
    public class No0168
    {
        public string ConvertToTitle(int columnNumber)
        {
            StringBuilder sb = new StringBuilder();

            while (columnNumber != 0)
            {
                columnNumber--;
                sb.Append((char)(columnNumber % 26 + 'A'));
                columnNumber /= 26;
            }

            StringBuilder title = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                title.Append(sb[i]);
            }

            return title.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class No1071
    {
        public string GcdOfStrings(string str1, string str2)
        {
            string common = "";
            for (int i = 0; i < str2.Length; i++)
            {
                if (str1[i]==str2[i])
                {
                    common += str1[i];
                }
            }

            return common;
        }
    }
}

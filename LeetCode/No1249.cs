using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class No1249
    {
        public string MinRemoveToMakeValid(string s)
        {
            HashSet<int> indexesToRemove = new HashSet<int>();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }

                else if (s[i]==')')
                {
                    if (stack.Count == 0)
                    {
                        indexesToRemove.Add(i);
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }

            while (stack.Count > 0)
            {
                indexesToRemove.Add(stack.Pop());
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (!indexesToRemove.Contains(i))
                {
                    sb.Append(s[i]);
                }
            }

            return sb.ToString();

            // #region Two Step String Builder
            // StringBuilder sb = new StringBuilder();
            // int openCount = 0;
            // int balanceCount = 0;
            // for (int i = 0; i < s.Length; i++)
            // {
            //     if (s[i] == '(')
            //     {
            //         openCount++;
            //         balanceCount++;
            //     }
            //     else if (s[i] == ')')
            //     {
            //         if (balanceCount == 0) continue;
            //         balanceCount--;
            //     }
            //
            //     sb.Append(s[i]);
            // }
            //
            // string str = sb.ToString();
            // sb = new StringBuilder();
            // int BalancedOpenCount = openCount - balanceCount;
            // for (int i = 0; i < str.Length; i++)
            // {
            //     if (str[i] == '(')
            //     {
            //         if (BalancedOpenCount <= 0) continue;
            //         BalancedOpenCount--;
            //     }
            //
            //     sb.Append(str[i]);
            // }
            //
            // return sb.ToString();
            //
            // #endregion
        }
    }
}
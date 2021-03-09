using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class No1047
    {
        public string RemoveDuplicates(string S)
        {
            char[] s = S.ToCharArray();
            Stack<char> stack = new Stack<char>();

            foreach (var t in s)
            {
                if (!stack.Any() || t != stack.Peek())
                {
                    stack.Push(t);
                }
                else
                {
                    stack.Pop();
                }
            }

            StringBuilder str = new StringBuilder();
            foreach (var c in stack)
            {
                str.Insert(0,c);
            }

            return str.ToString();
        }
    }
}
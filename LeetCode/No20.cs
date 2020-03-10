using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace LeetCode
{
    class No20
    {
        public bool IsValid(string s)
        {
            var mappings = new Dictionary<char, char> {{')', '('}, {']', '['}, {'}', '{'}};

            var stack = new Stack<char>();

            foreach (var c in s)
            {
                if (mappings.ContainsKey(c))
                {
                    var topElement = stack.Count == 0 ? '#' : stack.Pop();

                    if (topElement != mappings[c])
                    {
                        return false;
                    }
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }
    }
}
using System;
using System.Linq;
using System.Reflection;

namespace LeetCode
{
    public class PrimeOj
    {
        public int CountOne(int queue)
        {
            var s = Convert.ToString(queue, 2);
            return s.Count(c => c == '1');
        }
    }
}
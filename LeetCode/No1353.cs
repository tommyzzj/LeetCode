using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode
{
    public class No1353
    {
        public int MaxEvents(int[][] events)
        {
            var sorted = events.OrderBy(x => x[1]).ThenBy(x => x[0]).ToArray();
            int res = 0;
            var days = new HashSet<int>();
            foreach (var day in sorted)
            {
                for (int i = day[0]; i < day[1]; i++)
                {
                    if (!days.Contains(i))
                    {
                        days.Add(i);
                        res++;
                        break;
                    }
                }
            }

            return res;
        }
    }
}
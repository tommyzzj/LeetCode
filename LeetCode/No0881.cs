using System;

namespace LeetCode
{
    public class No0881
    {
        public int NumRescueBoats(int[] people, int limit)
        {
            int light = 0;
            int heavy = people.Length - 1;
            int ans = 0;
            
            Array.Sort(people);
            while (light <= heavy)
            {
                if (people[light] + people[heavy] <= limit)
                {
                    ++light;
                }

                --heavy;
                ++ans;
            }

            return ans;
        }
    }
}
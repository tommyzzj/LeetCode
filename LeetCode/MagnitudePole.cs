namespace LeetCode
{
    public class MagnitudePole
    {
        public int FindMagnitudePole(int[] data)
        {
            if (data.Length < 1)
            {
                return -1;
            }

            int poleIndex = 0;
            int poleValue = data[poleIndex];
            bool poleFound = true;

            for (int i = 0; i < data.Length; i++)
            {
                if (poleFound)
                {
                    if (data[i] >= poleValue)
                    {
                        continue;
                    }

                    poleFound = false;

                    while (++poleIndex < i)
                    {
                        if (data[poleIndex] > poleValue)
                        {
                            poleValue = data[poleIndex];
                        }
                    }
                }
                else
                {
                    if (data[i] >= poleValue)
                    {
                        poleIndex = i;
                        poleValue = data[i];
                        poleFound = true;
                    }
                }
            }

            if (poleFound)
            {
                return poleIndex;
            }

            return -1;
        }
    }
}
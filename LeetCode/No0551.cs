namespace LeetCode
{
    public class No0551
    {
        public bool CheckRecord(string s)
        {
            int a = 0;
            if (s.Contains("LLL"))
            {
                return false;
            }

            foreach (char d in s)
            {
                if (d == 'A')
                {
                    a++;
                }
            }

            if (a < 2)
            {
                return true;
            }

            return false;
        }
    }
}
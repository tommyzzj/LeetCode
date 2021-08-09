namespace LeetCode
{
    public class No0344
    {
        public void ReverseString(char[] s)
        {
            var l = s.Length;
            for (int left = 0, right = l - 1; left < right; ++left, --right)
            {
                var temp = s[left];
                s[left] = s[right];
                s[right] = temp;
            }
        }
    }
}
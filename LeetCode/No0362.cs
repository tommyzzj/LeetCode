namespace LeetCode
{
    public class No0362
    {
        public bool IsPowerOfThree(int n)
        {
            while (n != 0 && n % 3 == 0) {
                n /= 3;
            }
            return n == 1;
        }
    }
}
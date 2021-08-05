using System.Collections.Generic;

namespace LeetCode
{
    public class No0225
    {
        private Queue<int> q1;
        private Queue<int> q2;
        private int top;

        /** Initialize your data structure here. */
        public No0225()
        {
            q1 = new Queue<int>();
            q2 = new Queue<int>();
        }

        /** Push element x onto stack. */
        public void Push(int x)
        {
            q1.Enqueue(x);
            top = x;
        }

        /** Removes the element on top of the stack and returns that element. */
        public int Pop()
        {
            while(q1.Count > 1)
            {
                top = q1.Dequeue();
                q2.Enqueue(top);
            }

            var value = q1.Dequeue(); ;
            Queue<int> temp = q1;
            q1 = q2;
            q2 = temp;

            return value;
        }

        /** Get the top element. */
        public int Top()
        {
            return top;
        }

        /** Returns whether the stack is empty. */
        public bool Empty()
        {
            return q1.Count == 0;
        }
    }
}

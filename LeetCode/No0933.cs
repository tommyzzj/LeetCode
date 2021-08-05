using LeetCode.DataStructure;

namespace LeetCode
{
    public class No0933
    {
        // x 的信息
        int x;
        TreeNode xParent;
        int xDepth;
        bool xFound = false;

        // y 的信息
        int y;
        TreeNode yParent;
        int yDepth;
        bool yFound = false;

        public bool IsCousins(TreeNode root, int x, int y)
        {
            this.x = x;
            this.y = y;
            DFS(root, 0, null);
            return xDepth == yDepth && xParent != yParent;
        }

        public void DFS(TreeNode node, int depth, TreeNode parent)
        {
            if (node == null)
            {
                return;
            }

            if (node.val == x)
            {
                xParent = parent;
                xDepth = depth;
                xFound = true;
            }
            else if (node.val == y)
            {
                yParent = parent;
                yDepth = depth;
                yFound = true;
            }

            // 如果两个节点都找到了，就可以提前退出遍历
            // 即使不提前退出，对最坏情况下的时间复杂度也不会有影响
            if (xFound && yFound)
            {
                return;
            }

            DFS(node.left, depth + 1, node);

            if (xFound && yFound)
            {
                return;
            }

            DFS(node.right, depth + 1, node);
        }
    }
}
using System;
using System.Data;
using LeetCode.DataStructure;

namespace LeetCode
{
    public class No938
    {
        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return 0;
            }

            if (root.val < low)
            {
                return RangeSumBST(root.right, low, high);
            }

            if (root.val > high)
            {
                return RangeSumBST(root.left, low, high);
            }

            return root.val + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
        }
    }
}
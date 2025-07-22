/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public bool IsCousins(TreeNode root, int x, int y) {
        int xLevel = -1;
        int yLevel = -1;
        TreeNode xParent = null;
        TreeNode yParent = null;

        void Traverse(TreeNode root, int depth, TreeNode parent)
        {
            if(root is null)
                return;
            
            if(root.val == x)
            {
                xLevel = depth;
                xParent = parent;
            }
            else if(root.val == y)
            {
                yLevel = depth;
                yParent = parent;
            }

            Traverse(root.left, depth + 1, root);
            Traverse(root.right, depth + 1, root);
        }

        Traverse(root, 0, null);
        return xLevel == yLevel && xParent != yParent;
    }
}
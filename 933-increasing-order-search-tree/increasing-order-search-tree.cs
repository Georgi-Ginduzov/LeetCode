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
    TreeNode tree = null;
    public TreeNode Increase(TreeNode root)
    {
        if(root is null)
            return null;
        
        Increase(root.left);
        tree.right = new TreeNode(root.val);
        tree = tree.right;        
        Increase(root.right);

        return tree;
    }
    public TreeNode IncreasingBST(TreeNode root) {
        if(root is null)
            return null;
        
        var current = new TreeNode(-1);
        tree = current;
        
        Increase(root);

        return current.right;
    }
}
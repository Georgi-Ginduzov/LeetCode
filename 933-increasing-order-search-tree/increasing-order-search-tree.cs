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
    TreeNode newRoot;
    TreeNode current;

    public void InOrder(TreeNode root)
    {
        if(root is null)
            return;
        
        InOrder(root.left);
        var newNode = new TreeNode(root.val);
        current.right = newNode;
        current = current.right;
        InOrder(root.right);
    }

    public TreeNode IncreasingBST(TreeNode root) {
        this.newRoot = new TreeNode(0);
        this.current = this.newRoot;
        
        InOrder(root);
        return newRoot.right;
    }
}
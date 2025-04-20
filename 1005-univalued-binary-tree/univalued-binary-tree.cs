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
    public bool Differs(TreeNode root, int val)
    {
        if(root is null)
            return false;

        if(root.val != val)
            return true;
        
        if(Differs(root.left, val))
            return true;
        else
            return Differs(root.right, val);
    }

    public bool IsUnivalTree(TreeNode root) {
        return !Differs(root, root.val);
    }
}
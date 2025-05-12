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
    public bool ContainsPathSum(TreeNode root, int target, int current)
    {
        if(root is null)
            return false;
        
        current += root.val;
        if(current == target && root.left == null && root.right == null)
            return true;
        
        if(ContainsPathSum(root.left, target, current))
            return true;
        return ContainsPathSum(root.right, target, current);
    }   

    public bool HasPathSum(TreeNode root, int targetSum) {
        return ContainsPathSum(root, targetSum, 0);
    }
}
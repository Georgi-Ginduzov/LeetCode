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
    public int sum = 0;

    public void Leaves(TreeNode root)
    {
        if(root is null)
            return;
        
        if(root.left != null)
        {
            if(root.left.left == null && root.left.right == null)
                sum += root.left.val;
            else
                Leaves(root.left);
        }

        Leaves(root.right);
    }

    public int SumOfLeftLeaves(TreeNode root) 
    {
        Leaves(root);
        return sum;
    }
}
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
    int max = 0;

    public int Diameter(TreeNode root)
    {
        if(root is null)
            return -1;
        
        var left = Diameter(root.left);
        var right = Diameter(root.right);

        max = max > (left + right + 2) ? max : (left + right + 2);

        if(left > right)
            return left + 1;
        return right + 1;
    }

    public int DiameterOfBinaryTree(TreeNode root) {
        Diameter(root);
        return max;
    }
}
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
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2) {
        if(root1 is null)
            if(root2 is null)
                return root1;
            else
                return root2;
        else if(root2 is null)
            return root1;
        
        var left = MergeTrees(root1.left, root2.left);
        var right = MergeTrees(root1.right, root2.right);

        root1.val += root2.val;
        if(left is null)
            if(right is null)
                return root1;
            
        root1.left = left;
        root1.right = right;

        return root1;
    }
}
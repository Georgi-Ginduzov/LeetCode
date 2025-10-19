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
            return root2;
        if(root2 is null)
            return root1;
        
        root1.val += root2.val;
        if(root1.left is null)
            root1.left = root2.left;
        else if(root2.left != null)
            MergeTrees(root1.left, root2.left);
        
        if(root1.right is null)
            root1.right = root2.right;
        else if(root2.right != null)
            MergeTrees(root1.right, root2.right);
        
        return root1;
    }
}
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
    public int counter = 0;

    public int MaxDepth(TreeNode root) {
        if(root is null)
            return max;
        
        counter++;

        max = max > counter ? max : counter;

        MaxDepth(root.left);
        MaxDepth(root.right);
        counter--;

        return max;
    }
}
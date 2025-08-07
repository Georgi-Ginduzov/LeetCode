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
    int tilt = 0;
    public int Find(TreeNode root)
    {
        if(root is null)
            return 0;
        
        var left = Find(root.left);
        var right = Find(root.right);

        var nodeTilt = left - right;
        tilt += nodeTilt < 0 ? nodeTilt * -1 : nodeTilt;

        return left + right + root.val;
    }
    public int FindTilt(TreeNode root) {
        Find(root);
        return tilt;
    }
}
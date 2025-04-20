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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p is null)
        {
            if(q is null)
                return true;
            return false;
        }
        else if(q is null)
            return false;
        else if(p.val != q.val)
            return false;

        if(IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right))
            return true;
        else
            return false;
    }
}
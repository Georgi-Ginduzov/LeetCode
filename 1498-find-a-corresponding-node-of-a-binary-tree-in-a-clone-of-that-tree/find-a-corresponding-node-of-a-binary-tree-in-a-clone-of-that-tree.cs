/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        if(cloned is null)
            return null;
        if(cloned.val == target.val)
            return cloned;
        return GetTargetCopy(original, cloned.left, target) ?? GetTargetCopy(original, cloned.right, target);
    }
}
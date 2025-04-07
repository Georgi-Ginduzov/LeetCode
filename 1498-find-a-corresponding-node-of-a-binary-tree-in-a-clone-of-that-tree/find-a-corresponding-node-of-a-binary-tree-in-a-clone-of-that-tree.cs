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
    TreeNode node;
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        if(cloned == null)
            return null;

        if(cloned.val == target.val)
            node = cloned;
        GetTargetCopy(original, cloned.left, target);
        GetTargetCopy(original, cloned.right, target);

        return node;
    }
}
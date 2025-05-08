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
    HashSet<int> nums = new HashSet<int>();
    
    public bool FindTarget(TreeNode root, int k) {
        if(root is null)
            return false;
        
        if(nums.Contains(k-root.val))
            return true;
        else
            nums.Add(root.val);
        
        if(FindTarget(root.left, k))
            return true;
        return FindTarget(root.right, k);
    }
}
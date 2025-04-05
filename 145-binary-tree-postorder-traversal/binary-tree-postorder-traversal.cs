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
    List<int> ans = new List<int>();

    public IList<int> PostorderTraversal(TreeNode root) {
        if(root == null)
            return ans;
        
        PostorderTraversal(root.left);
        PostorderTraversal(root.right);
        ans.Add(root.val);

        return ans;
    }
}
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
    Dictionary<int, int> els = new Dictionary<int, int>();

    public void Traverse(TreeNode root)
    {
        if(root is null)
            return;
        
        Traverse(root.left);
        Traverse(root.right);

        if(els.ContainsKey(root.val))
            els[root.val]++;
        else
            els.Add(root.val, 1);
    }
    public int[] FindMode(TreeNode root) {
        Traverse(root);
        var max = els.Values.Max();
        
        return els.Where(e => e.Value == max).Select(e => e.Key).ToArray();
    }
}
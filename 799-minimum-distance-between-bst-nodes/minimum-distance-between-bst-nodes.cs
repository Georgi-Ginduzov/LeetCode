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
    public int MinDiffInBST(TreeNode root) {
        List<int> nodes = new List<int>();
        nodes = RootToList(root, nodes);
        
        int minDiff = int.MaxValue;
        for(int i = 1; i < nodes.Count; i++)
        {
            minDiff = minDiff < nodes[i] - nodes[i-1] ? minDiff : nodes[i] - nodes[i-1];
        }

        return minDiff;
    }

    public List<int> RootToList(TreeNode root, List<int> list)
    {
        if(root is null)
            return list;
        
        RootToList(root.left, list);
        list.Add(root.val);
        RootToList(root.right, list);

        return list;
    }
}
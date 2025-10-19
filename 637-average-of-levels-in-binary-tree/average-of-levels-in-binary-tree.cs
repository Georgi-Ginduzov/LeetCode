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
    private Dictionary<int, List<long>> levels = new Dictionary<int, List<long>>();
    private void Dfs(TreeNode root, int depth)
    {
        if(root is null)
            return;
        
        if(levels.ContainsKey(depth))
            levels[depth].Add(root.val);
        else
            levels.Add(depth, new List<long>(){root.val});
        
        Dfs(root.left, depth + 1);
        Dfs(root.right, depth + 1);
    }

    public IList<double> AverageOfLevels(TreeNode root) {
        Dfs(root, 1);

        var averages = new List<double>(levels.Count);
        foreach(var level in levels.Values)
            averages.Add(level.Sum() / (double)level.Count);
        
        return averages;
    }
}
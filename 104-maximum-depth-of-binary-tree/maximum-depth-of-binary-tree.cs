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
    public int MaxDepth(TreeNode root) {
        if(root is null)
            return 0;
        int depth = 0;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Any())
        {
            depth++;
            int count = q.Count;
            while(count-- > 0)
            {
                var node = q.Dequeue();
                if(node.left != null)
                    q.Enqueue(node.left);
                if(node.right != null)
                    q.Enqueue(node.right);
            }
        }

        return depth;
    }
}
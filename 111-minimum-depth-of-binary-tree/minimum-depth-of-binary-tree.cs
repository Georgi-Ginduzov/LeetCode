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
    public int MinDepth(TreeNode root) {
        if(root is null)
            return 0;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int depth = 0;
        while(queue.Any())
        {
            depth++;
            var count = queue.Count;
            for(int i = 0; i < count; i++)
            {
                var el = queue.Dequeue();
                if(el.left is null)
                    if(el.right is null)
                        return depth;
                    else
                        queue.Enqueue(el.right);
                else if(el.right is null)
                    queue.Enqueue(el.left);
                else
                {
                    queue.Enqueue(el.left);
                    queue.Enqueue(el.right);
                }
            }
        }

        return depth;
    }
}
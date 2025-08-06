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
    public IList<double> AverageOfLevels(TreeNode root) {
        IList<double> levels = new List<double>();

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            var levelCount = queue.Count;
            double sum = 0;
            for(int i = 0; i < levelCount; i++)
            {
                var el = queue.Dequeue();
                sum += el.val;

                if(el.left is null)
                    if(el.right is null)
                        continue;
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

            levels.Add(sum / levelCount);
        }

        return levels;
    }
}
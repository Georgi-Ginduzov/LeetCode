public class Solution {
    public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target) {
        var tree = new Queue<TreeNode>();
        tree.Enqueue(cloned);

        while(tree.Any())
        {
            var node = tree.Dequeue();
            if(node.val == target.val)
                return node;
            
            if(node.left != null)
                tree.Enqueue(node.left);
            if(node.right != null)
                tree.Enqueue(node.right);
        }

        return null;
    }
}
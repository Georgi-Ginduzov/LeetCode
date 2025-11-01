public class Solution {
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        var leaves1 = new Queue<int>();
        void CollectLeaves(TreeNode root)
        {
            if(root is null)
                return;
            if(root.left is null && root.right is null)
            {
                leaves1.Enqueue(root.val);
            }
            else
            {
                CollectLeaves(root.left);
                CollectLeaves(root.right);
            }
        }
        CollectLeaves(root1);

        bool CompareRootToQueue(TreeNode root)
        {
            if(root is null)
                return true;
            if (!CompareRootToQueue(root.left))
                return false;
            if(root.left is null && root.right is null)
            {
                if(leaves1.Count == 0 || leaves1.Dequeue() != root.val)
                    return false;
            }
            return CompareRootToQueue(root.right);
        }

        return CompareRootToQueue(root2) && leaves1.Count == 0;
    }
}
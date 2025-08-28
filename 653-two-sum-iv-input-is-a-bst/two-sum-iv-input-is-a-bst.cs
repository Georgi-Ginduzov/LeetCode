public class Solution {
    public bool FindTarget(TreeNode root, int k) {
        var s = new HashSet<int>();
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        
        while(q.Any())
        {
            var el = q.Dequeue();

            if(s.Contains(el.val))
                return true;
            s.Add(k - el.val);

            if(el.left != null)
                q.Enqueue(el.left);
            if(el.right != null)
                q.Enqueue(el.right);
        }

        return false;
    }
}
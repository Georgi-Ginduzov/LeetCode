public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if(p is null)
            return q is null;
        else if(q is null)
            return false;
        
        var queue = new Queue<(TreeNode, TreeNode)>();
        queue.Enqueue((p, q));
        while(queue.Any())
        {
            (var l, var r) = queue.Dequeue();
            if(l.val != r.val)
                return false;
            
            if(l.left != null)
                if(r.left != null)
                    queue.Enqueue((l.left, r.left));
                else
                    return false;
            else if(r.left != null)
                return false;

            if(l.right != null)
                if(r.right != null)
                    queue.Enqueue((l.right, r.right));
                else
                    return false;
            else if(r.right != null)
                return false;
        }

        return true;
    }
}
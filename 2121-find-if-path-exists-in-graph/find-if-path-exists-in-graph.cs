public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        if(source == destination)
            return true;

        var graph = new Dictionary<int, HashSet<int>>();
        for(int i = 0; i < n; i++)
            graph.Add(i, new HashSet<int>());
        
        foreach(var edge in edges)
        {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }

        var queue = new Queue<int>();
        queue.Enqueue(source);
        var visited = new HashSet<int>();
        visited.Add(source);

        while(queue.Count > 0)
        {
            var node = queue.Dequeue();

            foreach(var grNode in graph[node])
            {
                if(grNode == destination)
                    return true;
                if(visited.Add(grNode))
                    queue.Enqueue(grNode);
            }
        }

        return false;
    }
}
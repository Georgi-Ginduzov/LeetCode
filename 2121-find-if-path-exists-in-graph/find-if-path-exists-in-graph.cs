public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        if(source == destination)
            return true;
        
        var graph = new Dictionary<int, HashSet<int>>();
        for(int i = 0; i < n; i++) // Adds all nodes => self nodes are added as well
            graph.Add(i, new HashSet<int>());
        
        for(int i = 0; i < edges.Length; i++)
        {
            graph[edges[i][0]].Add(edges[i][1]);
            graph[edges[i][1]].Add(edges[i][0]);
        }

        var paths = new Queue<int>();
        var visited = new HashSet<int>();
        paths.Enqueue(source);
        visited.Add(source);

        while(paths.Count > 0)
        {
            var node = paths.Dequeue();

            foreach(var connectedNode in graph[node])
            {
                if(connectedNode == destination)
                    return true;
                if(!visited.Contains(connectedNode))
                {
                    paths.Enqueue(connectedNode);
                    visited.Add(connectedNode);
                }
            }
        }

        return false;
    }
}
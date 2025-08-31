/*
    1971. Find if Path Exists in Graph
Easy
Topics
premium lock icon
Companies
There is a bi-directional graph with n vertices, where each vertex is labeled from 0 to n - 1 (inclusive). 
The edges in the graph are represented as a 2D integer array edges, 
where each edges[i] = [ui, vi] denotes a bi-directional edge between vertex ui and vertex vi. 
Every vertex pair is connected by at most one edge, and no vertex has an edge to itself.

You want to determine if there is a valid path that exists from vertex source to vertex destination.

Given edges and the integers n, source, and destination, return true if there is a valid path from source to destination, 
or false otherwise.

    - Use BFS
    - Get the destination
    - Find it inside the edges matrix
    - get all paths which lead to destination
    - add them to the queue
    - get all paths leading to these elements
    - if any one of them is equal to source return true
    - finally return false, hence its path is not found after traversing all paths from source
*/
public class Solution {
    public bool ValidPath(int n, int[][] edges, int source, int destination) {
        var graph = new Dictionary<int, List<int>>();
        for(int i=0; i <n; i++)
            graph.Add(i, new List<int>());
        
        for(int i = 0; i < edges.Length; i++)
        {
            graph[edges[i][0]].Add(edges[i][1]);
            graph[edges[i][1]].Add(edges[i][0]);
        }

        var visited = new HashSet<int>();
        visited.Add(source);
        var q = new Queue<int>();
        q.Enqueue(source);

        while(q.Any())
        {
            var el = q.Dequeue();
            if(el == destination)
                return true;
            
            foreach(var node in graph[el])
            {
                if(visited.Contains(node))
                    continue;
                visited.Add(node);
                q.Enqueue(node);
            }
        }

        return false;
    }
}
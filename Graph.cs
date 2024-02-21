using System;

public class Graph
{
    public Graph()
    {

        private List<int>[] adj;

    Graph(int v)
    {
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    // Method to add an edge into the graph
    void addEdge(int v, int w)
    {

        // Add w to v's list.
        adj[v].Add(w);
    }

    // A recursive method to count
    // all paths from 'u' to 'd'.
    int countPathsUtil(int u, int d, int pathCount)
    {

        // If current vertex is same as
        // destination, then increment count
        if (u == d)
        {
            pathCount++;
        }

        // Recur for all the vertices
        // adjacent to this vertex
        else
        {
            foreach (int i in adj[u])
            {
                int n = i;
                pathCount = countPathsUtil(n, d, pathCount);
            }
        }
        return pathCount;
    }

    // Returns count of
    // paths from 's' to 'd'
    int countPaths(int s, int d)
    {

        // Call the recursive method
        // to count all paths
        int pathCount = 0;
        pathCount = countPathsUtil(s, d, pathCount);
        return pathCount;
    }
    }
}

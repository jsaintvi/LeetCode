public class Solution {
    public IList<bool> CheckIfPrerequisite(int numCourses, int[][] prerequisites, int[][] queries) {

      List<int>[] graph = CreateEmptyGraph(numCourses);

        int[] inDegree = new int[numCourses];

        // add edges and keep track of in-degree count
        foreach (var prereq in prerequisites)
        {
            graph[prereq[0]].Add(prereq[1]);
            inDegree[prereq[1]]++;
        }

        List<int> sortedCourses = TopologicalSort(graph, inDegree);

        // Create a matrix to store whether a course is a prerequisite for another
        bool[,] isPrerequisite = new bool[numCourses, numCourses];
        foreach (var course in sortedCourses)
        {
            foreach (var neighbor in graph[course])
            {
                for (int i = 0; i < numCourses; i++)
                {
                    isPrerequisite[i, neighbor] |= isPrerequisite[i, course];
                    isPrerequisite[i, neighbor] |= (i == course); // A course is a prerequisite for itself
                }
            }
        }



        List<bool> result = new List<bool>();
        foreach (var query in queries)
        {
            result.Add(isPrerequisite[query[0], query[1]]);
        }

        return result;
    }
    
    private List<int> TopologicalSort(List<int>[] graph, int[] inDegree)
    {
        List<int> result = new List<int>();
        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < inDegree.Length; i++)
        {
            if (inDegree[i] == 0)
            {
                queue.Enqueue(i);
            }
        }

        while (queue.Count > 0)
        {
            int node = queue.Dequeue();
            result.Add(node);

            foreach (var neighbor in graph[node])
            {
                inDegree[neighbor]--;

                if (inDegree[neighbor] == 0)
                {
                    queue.Enqueue(neighbor);
                }
            }
        }

        if (result.Count != graph.Length)
        {
            throw new InvalidOperationException("The graph has a cycle, so topological sorting is not possible.");
        }

        return result;
    }
    
    // private void AddEdge(List<int>[] g, int from, to)
    // {
    //     g[start].Add(to);
    // }
    
    private List<int>[] CreateEmptyGraph(int numCourses)
    {
        List<int>[] adj = new List<int>[numCourses];
        
        for(int i = 0; i < numCourses; i++)
        {
            adj[i] = new List<int>();
        }
        
        return adj;
    }
}


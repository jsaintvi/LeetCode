public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        List<int>[] graph = new List<int>[numCourses];
        int[] indegree = new int[numCourses];
        for(int i = 0; i < numCourses; i++) {
            graph[i] = new List<int>();
        }
        
        foreach(var prereq in prerequisites)
        {
            int course = prereq[0];
            int prereqCourse = prereq[1];
            
            indegree[course]++;
            
            graph[prereqCourse].Add(course);
        }
        
        Queue<int> q = new();
        for(int i = 0; i < numCourses; i++) {
            if(indegree[i] == 0)
                q.Enqueue(i);
        }
        
        int visitedCourse = 0;
        while(q.Count > 0) {
            var course = q.Dequeue();
            visitedCourse+=1;
            
            foreach(var neighborCourse in graph[course])
            {
                indegree[neighborCourse]--;
                
                if(indegree[neighborCourse] == 0)
                    q.Enqueue(neighborCourse);
            }
        }
        
        return visitedCourse == numCourses;
    }
}
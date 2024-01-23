public class Solution {
    public record State(string combination, int openCount, int closeCount);
    
    public IList<string> GenerateParenthesis(int n) {
        List<string> result = new List<string>();
        
        Queue<State> q = new();
        q.Enqueue(new State("(", 1, 0));
        
        while(q.Count > 0) {
            var curr = q.Dequeue();
            if(curr.openCount == n && curr.closeCount == n)
            {
                result.Add(curr.combination);
                continue;
            }
            
            if(curr.openCount < n) {
                q.Enqueue(new State(curr.combination + "(", curr.openCount + 1, curr.closeCount));
            }
            
            if(curr.closeCount < n &&curr.closeCount < curr.openCount) {
                q.Enqueue(new State(curr.combination + ")", curr.openCount, curr.closeCount + 1));
 
            }
        }
            
        return result;
        
    }
}
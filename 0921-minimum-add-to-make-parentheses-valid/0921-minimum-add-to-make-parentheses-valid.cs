public class Solution {
    public int MinAddToMakeValid(string s) {
        Stack<char> st = new();
        
        int count=0;
        
        for(int i = 0; i < s.Length; i++){
            if(s[i] == ')') {
                if(st.Count == 0)
                    count++;
                else if(st.Peek() == '(')
                      st.Pop();
            }
            else if(s[i]=='(')
                st.Push(s[i]);
        }
        return st.Count+count;
    }
}
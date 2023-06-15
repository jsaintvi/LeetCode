public class Solution {
    public bool IsValid(string s) {
        Stack<char> st = new();
        
        Dictionary<char,char> map = BuildValidBrackets();
        
        for(int i = 0; i < s.Length; i++) {
            
            if(map.ContainsKey(s[i])){
                char topElem = st.Count > 0 ? st.Pop() : ' ';
                
                if(topElem != map[s[i]])
                    return false;  
            } else {
                st.Push(s[i]);
            }            
        }
        
        return st.Count == 0;
    }
    
    private Dictionary<char,char> BuildValidBrackets(){
        Dictionary<char,char> map = new()
        {
            {')', '('},
            {'}', '{'},
            {']', '['}
        };
        return map;
    }
}
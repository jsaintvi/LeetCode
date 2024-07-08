public class Solution {
    private record Payload (string CurrentWord, int Length);
    
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        var wordSet = new HashSet<string>(wordList);
        
        if(!wordSet.Contains(endWord)) return 0;
        
        Queue<Payload> q = new Queue<Payload>();
        q.Enqueue(new Payload(beginWord, 1));
        
        while(q.Count > 0)
        {
            var data = q.Dequeue();
            
            if(data.CurrentWord == endWord)
                return data.Length;
                
            
            var currWordArr = data.CurrentWord.ToCharArray();
            for(int i = 0; i < currWordArr.Length; i++)
            {
                var orginalChar = currWordArr[i];
                
                // try all the char of the alphabet for a potential match
                for(char c = 'a'; c <= 'z'; c++)
                {
                    if(c == orginalChar) continue;
                    
                    currWordArr[i] = c;
                    
                    var newWord = new String(currWordArr);
                    
                    if(wordSet.Contains(newWord))
                    {
                        q.Enqueue(new Payload(newWord, data.Length + 1));
                        wordSet.Remove(newWord);
                    }
                }
                currWordArr[i] = orginalChar;
            }
        }
        
        return 0;
    }
}
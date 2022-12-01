public class Solution {
    public bool ValidWordSquare(IList<string> words) {
        
        for(int i = 0; i < words.Count; i++) {
            for(int j = 0; j < words[i].Length; j++) {
                int row = j;
                int col = i;
                if (row > words.Count-1)
                    return false;
                if (words[row].Length -1 < col)
                    return false;
                if (words[i][j] != words[j][i])
                    return false;
            }
        }
        return true;
    }
}
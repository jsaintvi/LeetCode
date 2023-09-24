public class Solution {
    public int[] ProcessQueries(int[] queries, int m) {
        int[] p = new int[m];
        
        // init perms arr
        for(int i = 0; i < m; i++)
            p[i] = i + 1;
            
        int[] answer = new int[queries.Length];

        for(int i = 0; i < queries.Length; i++){
            int numberToFind = queries[i];
            answer[i] = FindPosition(p, numberToFind);
            
            Console.WriteLine($"Found Pos of {numberToFind} in P at index {answer[i]}");
            ShiftToBeginnigOfArr(p, answer[i], numberToFind);
            Console.WriteLine($"Shifting {numberToFind} to beginning of P");
        }
        return answer;
    }
    public int FindPosition(int[] p, int numberToFind){
        for(int i = 0; i < p.Length; i++){
            if(p[i] == numberToFind){
                return i;
            }
        }
        return -1;
    }
    public void ShiftToBeginnigOfArr(int[] p, int position, int numberToFind){
        for(int i = position - 1; i >= 0; i--){
            p[i + 1] = p[i];
        }
        p[0] = numberToFind;
    }
}
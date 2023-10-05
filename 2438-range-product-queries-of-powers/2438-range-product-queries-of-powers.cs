public class Solution {
    public int[] ProductQueries(int n, int[][] queries) {
       var result = new List<int>(queries.Length);
        var list = new List<int>();
                long mod = (long)Math.Pow(10, 9) + 7;

        for (var currentPow = 1; currentPow != 0; currentPow <<= 1)
            if ((currentPow & n) != 0)
                list.Add(currentPow);

        foreach (var query in queries)
        {
            BigInteger r = 1;
            
            for (var j = query[0]; j <= query[1]; j++)
                r *= list[j];

            result.Add((int)(r % mod));
        }

        return result.ToArray();
    }
    
    private int[] ConstructArr(int n)
    {
        List<int> ans = new();
//        int k = 1;

//         while(k <= n)
//         {
//             ans.Add(k);
//             k *= 2;
//         }
        for (var currentPow = 1; currentPow != 0; currentPow <<= 1)
            if ((currentPow & n) != 0)
                ans.Add(currentPow);
        return ans.ToArray();
    }
}
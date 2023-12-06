public class Solution
{
    public int[] CountPoints(int[][] points, int[][] queries)
    {
        Array.Sort(points, (p1, p2) => p1[0].CompareTo(p2[0]));
        
        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; i++)
        {
            double x = queries[i][0];
            double y = queries[i][1];
            double r = queries[i][2];
            int count = 0;
            int j = 0;
            while (j < points.Length && points[j][0] <= x + r)
            {
                double d = Math.Sqrt(Math.Pow(points[j][0] - x, 2) + Math.Pow(points[j][1] - y, 2));
                if (d <= r)
                {
                    count++;
                }
                j++;
            }
            
            result[i] = count;
        }

        return result;
    }
}
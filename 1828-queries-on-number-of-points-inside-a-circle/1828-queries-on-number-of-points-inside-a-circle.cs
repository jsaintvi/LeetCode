public class Solution
{
    public int[] CountPoints(int[][] points, int[][] queries)
    {
        List<(double x, double y, int count)> circles = new List<(double x, double y, int count)>();
        for (int i = 0; i < queries.Length; i++)
        {
            int x = queries[i][0];
            int y = queries[i][1];
            int r = queries[i][2];
            
            int count = 0;
            foreach (var point in points)
            {
                var xp = point[0];
                var yp = point[1];
                // calc distance  between the 2 points
                double d = Math.Sqrt(Math.Pow(xp - x, 2) + Math.Pow(yp - y, 2));
                if (d <= r)
                {
                    count++;
                }
            }
            circles.Add((x, y, count));
        }

        return circles.Select(circle => circle.count).ToArray();
    }
}
public class Solution
{
    public int[] CountPoints(int[][] points, int[][] queries)
    {
        List<(double x, double y, int idx)> circlePoints = new List<(double x, double y, int idx)>();
        for (int i = 0; i < points.Length; i++)
        {
            circlePoints.Add((points[i][0], points[i][1], i));
        }

        List<(double x, double y, int count)> circles = new List<(double x, double y, int count)>();
        for (int i = 0; i < queries.Length; i++)
        {
            double x = queries[i][0];
            double y = queries[i][1];
            double r = queries[i][2];
            int count = 0;
            foreach (var (xp, yp, idx) in circlePoints)
            {
                // calc distance 
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
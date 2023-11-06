public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var buckets = BuildBuckets(nums);

        int count = 0;
        List<int> res = new List<int>();
        for(int i = buckets.Count-1; i > 0; i--)
        {
            if(buckets[i] == null) continue;

            foreach(var val in buckets[i])
            {
                if(count >= k) break;

                res.Add(val);
                count++;
            }

        }
        return res.ToArray();
    }

    /**
      Build buckets where elm is placed on bucket {i} when they appear {i} times
    */
    private List<List<int>> BuildBuckets(int[] nums)
    {
        // build freq map
        var map = new Dictionary<int,int>();

        foreach(var num in nums)
        {
            if(!map.ContainsKey(num)) map.Add(num, 0);

            map[num]++;
        }

        var buckets = new List<List<int>>(nums.Length + 1);

        for(int i = 0; i <= nums.Length; i++)
        {
            buckets.Add(new List<int>());
        }

        foreach(var kv in map)
        {
            buckets[kv.Value].Add(kv.Key);
        }

        return buckets;
    }
}
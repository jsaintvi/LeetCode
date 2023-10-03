public class Solution {
    public int ReversePairs(int[] nums) {
        int res = 0;
        int[] copy = new int[nums.Length];
        Array.Copy(nums, copy, nums.Length);
        int[] bit = new int[copy.Length + 1];

        Array.Sort(copy);

        foreach (int ele in nums) {
            res += Search(bit, Index(copy, 2L * ele + 1));
            Insert(bit, Index(copy, ele));
        }

        return res;
    }
    
    private int LSB(int i) => i & -i;
    private int Search(int[] bit, int i) {
        int sum = 0;

        while (i < bit.Length) {
            sum += bit[i];
            i +=LSB(i);
        }

        return sum;
    }

    private void Insert(int[] bit, int i) {
        while (i > 0) {
            bit[i] += 1;
            i -= LSB(i);
        }
    }
    
    private int Index(int[] arr, long val) {
        int l = 0, r = arr.Length - 1, m = 0;

        while (l <= r) {
            m = l + ((r - l) >> 1);

            if (arr[m] >= val) {
                r = m - 1;
            } else {
                l = m + 1;
            }
        }

        return l + 1;
    }
}
public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        int target = nums.Length / 2;

        foreach(int n in nums)
        {
            if (!countMap.ContainsKey(n))
            {
                countMap[n] = 0;
            }
            countMap[n]++;

            if (countMap[n] > target)
            {
                return n;
            }
        }

        return 0;
    }
}
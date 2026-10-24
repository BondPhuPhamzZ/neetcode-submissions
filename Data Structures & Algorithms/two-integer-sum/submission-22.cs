public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            int complementKey = target - nums[i];
            if (seen.ContainsKey(complementKey))
            {
                return new int[]{seen[complementKey], i};
            }
            seen[nums[i]] = i;
        }
        return new int[0];
    }
}

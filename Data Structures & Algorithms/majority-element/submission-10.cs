public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        int target = nums.Length / 2;

        foreach (int num in nums)
        {
            if (!countMap.ContainsKey(num))
            {
                countMap[num] = 0;
            }
            countMap[num]++;

            if (countMap[num] > target)
            {
                return num;
            }
        }

        return 0;
    }
}
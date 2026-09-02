public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seenNum = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int currentNum = nums[i];
            int complement = target - currentNum;
            if (seenNum.ContainsKey(complement))
            {
                return new int[] {seenNum[complement], i};
            }
            seenNum[currentNum] = i;
        }

        return new int[0];

    }
}

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seenNumber = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int currentNum = nums[i];

            int complement = target - currentNum;

            if (seenNumber.ContainsKey(complement))
            {
                return new int[] {seenNumber[complement], i};
            }
            seenNumber[currentNum] = i;

        }

        return new int[0];

    }
}

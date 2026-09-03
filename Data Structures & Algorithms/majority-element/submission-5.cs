public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> countNum = new Dictionary<int, int>();

        int target = nums.Length / 2;

        foreach(int num in nums)
        {
            if (!countNum.ContainsKey(num))
            {
                countNum[num] = 0;
            }
            countNum[num]++;

            if (countNum[num] > target)
            {
                return num;
            }
        }

        return 0;
    }
}
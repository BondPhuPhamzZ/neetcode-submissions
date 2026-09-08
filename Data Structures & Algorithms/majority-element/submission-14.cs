public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> choose = new Dictionary<int, int>();

        int target = nums.Length / 2;

        foreach (int num in nums)
        {
            if (!choose.ContainsKey(num))
            {
                choose[num] = 0;
            }
            choose[num]++;

            if (choose[num] > target)
            {
                return num;
            }
        }

        return 0;
    }
}
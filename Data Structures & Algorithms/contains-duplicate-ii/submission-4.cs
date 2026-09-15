public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int currentNum = nums[i];
            if (dict.ContainsKey(currentNum))
            {
                int oldIndex = dict[currentNum];
                int distance = i - oldIndex;

                if (distance <= k)
                {
                    return true;
                }
                dict[currentNum] = i;
                
            }
            else
            {
                dict.Add(currentNum, i);
            }
        }

        return false;

    }
}
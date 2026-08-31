public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> checkDupe = new HashSet<int>();

        foreach(int num in nums)
        {
            if(checkDupe.Contains(num))
            {
                return true;
            }
            checkDupe.Add(num);
        }

        return false;

    }
}
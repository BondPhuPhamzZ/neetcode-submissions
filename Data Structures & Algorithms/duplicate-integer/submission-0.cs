public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> seenNumbers = new HashSet<int>();

        foreach (int num in nums)
        {
            if (seenNumbers.Contains(num))
            {
                return true;
            }
            seenNumbers.Add(num);
        }

        return false;

    }
}
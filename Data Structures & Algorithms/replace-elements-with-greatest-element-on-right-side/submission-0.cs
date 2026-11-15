public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int maxRight = -1;
            for (int j = i + 1; j < n; j++)
            {
                maxRight = Math.Max(maxRight, arr[j]);
            }
            arr[i] = maxRight;
        }
        
        arr[n - 1] = -1;
        return arr;
    }
}
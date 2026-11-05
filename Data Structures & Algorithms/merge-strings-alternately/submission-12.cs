public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string result = "";
        int i = 0;
        int m = word1.Length;
        int n = word2.Length;

        while (i < m || i < n)
        {
            if (i < m)
            {
                result += word1[i];
            }
            if (i < n)
            {
                result += word2[i];
            }
            i++;
        }

        return result.ToString();
    }
}
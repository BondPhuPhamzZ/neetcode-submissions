public class Solution {
    public string MergeAlternately(string word1, string word2) {
        StringBuilder result = new StringBuilder();
        int i = 0;
        int m = word1.Length;
        int n = word2.Length;

        while (i < m || i < n)
        {
            if (i < m)
            {
                result.Append(word1[i]);
            }
            if (i < n)
            {
                result.Append(word2[i]);
            }
            i++;
        }

        return result.ToString();

    }
}
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        Array.Sort(sArray);
        Array.Sort(tArray);

        string sSorted = new string(sArray);
        string tSorted = new string(tArray);

        return sSorted == tSorted;
    }
}

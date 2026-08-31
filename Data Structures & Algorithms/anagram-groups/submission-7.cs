public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string s in strs)
        {
            char[] counts = new char[26];
            foreach(char c in s)
            {
                counts[c - 'a']++;
            }

            string key = new string(counts);

            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(s);

        }
        return new List<List<string>>(map.Values);

    }
}

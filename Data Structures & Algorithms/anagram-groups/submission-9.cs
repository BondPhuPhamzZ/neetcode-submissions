public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string s in strs)
        {
            char[] count = new char[26];
            foreach(char c in s)
            {
                count[c - 'a']++;
            }

            string key = new string(count);

            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(s);
        }

        return new List<List<string>>(map.Values);
    }
}

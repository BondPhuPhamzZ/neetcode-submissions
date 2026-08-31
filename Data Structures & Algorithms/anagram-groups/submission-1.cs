public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string s in strs)
        {
            char[] convert = s.ToCharArray();
            Array.Sort(convert);
            string key = new string(convert);

            // Nếu Dictionary chưa có cái badge (chưa có key nào mang tên đã xếp)
            if (!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            // Nếu đã có badge mang đúng key -> add giá trị vào mảng key
            map[key].Add(s);
        }
        return new List<List<string>>(map.Values);
    }
}

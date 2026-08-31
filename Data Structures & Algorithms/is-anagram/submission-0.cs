public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }

        // Chuyển chuỗi string thành mảng ký tự (char array) để có thể sắp xếp
        char[] sArray = s.ToCharArray();
        char[] tArray = t.ToCharArray();

        // Sắp xếp 2 mảng ký tự theo bảng chữ cái (A-Z)
        Array.Sort(sArray);
        Array.Sort(tArray);

        // Khởi tạo thành chuỗi mới từ mảng đã được sắp xếp
        string sortedS = new string(sArray);
        string sortedT = new string(tArray);

        // So sánh 2 chuỗi -> giống = true
        return sortedS == sortedT;

    }
}

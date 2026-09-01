public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        // Lấy từ đầu tiên làm tiền tố giả định
        string prefix = strs[0];

        // Duyệt qua các từ còn lại trong mảng
        for (int i = 0; i < strs.Length; i++)
        {   
            // Nếu từ hiện tại chưa bắt đầu bằng prefix (đủ điều kiện để cắt đuôi)
            while(strs[i].IndexOf(prefix) != 0)
            {
                // Cắt bỏ 1 chữ cái ở đuôi của prefix
                prefix = prefix.Substring(0, prefix.Length - 1);

                // Nếu cắt mà prefix rỗng -> ko có khúc đầu nào giống nhau
                if (prefix == "")
                {
                    return "";
                }

            }
        }

        return prefix;


    }
}
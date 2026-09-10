public class Solution {
    public bool ValidPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] == s[right])
            {
                left++;
                right--;
            }
            else
            {
                bool skipLeft = IsStrictPalindrome(s, left + 1, right);
                bool skipRight = IsStrictPalindrome(s, left, right - 1);
                return skipLeft || skipRight;
            }
        }

        return true;
    }

    private bool IsStrictPalindrome (string s, int left, int right)
    {
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

}
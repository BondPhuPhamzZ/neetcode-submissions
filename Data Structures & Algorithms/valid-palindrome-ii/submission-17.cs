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
                return PalindromeRange(s, left + 1, right) || PalindromeRange(s, left, right - 1);
            }
        }

        return true;

    }
    
    private bool PalindromeRange(string s, int i, int j)
    {
        while (i < j)
        {
            if (s[i] != s[j])
            {
                return false;
            }
            i++;
            j--;
        }

        return true;
    }

}
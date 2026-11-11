public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == '(' || c == '[' || c =='{')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                
                char top = stack.Pop();

                if (c == ')' && top != '(')
                {
                    return false;
                }
                if (c == ']' && top != '[')
                {
                    return false;
                }
                if (c == '}' && top != '{')
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;

    }
}

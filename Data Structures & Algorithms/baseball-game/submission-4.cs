public class Solution {
    public int CalPoints(string[] operations) {
        int n = operations.Length;
        int[] scores = new int[n];
        int top = -1;

        for (int i = 0; i < n; i++)
        {
            string op = operations[i];

            if (op == "+")
            {
                int sum = scores[top] + scores[top - 1];
                scores[++top] = sum;
            }
            else if (op == "D")
            {
                int doubleScore = scores[top] * 2;
                scores[++top] = doubleScore;
            }
            else if (op == "C")
            {
                top--;
            }
            else
            {
                scores[++top] = int.Parse(op);
            }
        }

        int total = 0;
        for (int i = 0; i <= top; i++)
        {
            total += scores[i];
        }

        return total;

    }
}
public class Solution {
    public int CalPoints(string[] operations) {
        List<int> scores = new List<int>();

        foreach(string op in operations)
        {
            if (op == "+")
            {
               int sum = scores[scores.Count - 1] + scores[scores.Count - 2];
               scores.Add(sum);
            }
            else if (op == "D")
            {
               int doubleScore = scores[scores.Count - 1] * 2;
               scores.Add(doubleScore);
            }
            else if (op == "C")
            {
               scores.RemoveAt(scores.Count - 1);
            }
            else
            {
                scores.Add(int.Parse(op));
            }
        }

        int total = 0;
        foreach(int score in scores)
        {
            total += score;
        }
        return total;

    }
}
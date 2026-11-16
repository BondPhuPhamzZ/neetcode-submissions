public class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;

        foreach (string passenger in details)
        {
            string ageString = passenger.Substring(11, 2);
            
            int age = int.Parse(ageString);

            if (age > 60)
            {
                count++;
            }
        }

        return count;

    }
}
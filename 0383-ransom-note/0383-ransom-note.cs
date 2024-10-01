public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char, int> letters = new Dictionary<char, int>();
        for (int i = 0; i < magazine.Length; i++)
            if (letters.ContainsKey(magazine[i]))
                letters[magazine[i]] += 1;
            else
                letters.Add(magazine[i], 1);

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (letters.ContainsKey(ransomNote[i]))
            {
                if (letters[ransomNote[i]] > 0)
                    letters[ransomNote[i]] -= 1;
                else
                    return false;
            }
            else
                return false;
        }

        return true;
    }
}
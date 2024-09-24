public class Solution {
    public bool IsSubsequence(string s, string t) {
        int j = 0;
        int i = 0;
        
        while (i < t.Length && j < s.Length)
        {
            if (t[i] == s[j])
            {
                i++;
                j++;
            }
            while (i < t.Length && j < s.Length && t[i] != s[j])
                i++;
        }

        if(j == s.Length)
            return true;
        return false;
    }
}
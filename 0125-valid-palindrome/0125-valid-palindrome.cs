public class Solution {
    public bool IsPalindrome(string s) {
        int i = 0;
        int j = s.Length - 1;

        while(i < j)
        {
            while(i < s.Length && !Char.IsLetterOrDigit(s[i]))
                i++;
            while(j >= 0 && !Char.IsLetterOrDigit(s[j]))
                j--;

            if (i < j && Char.ToLower(s[i]) != Char.ToLower(s[j]))
                return false;
            
            i++;
            j--;
        }

        return true;
    }
}
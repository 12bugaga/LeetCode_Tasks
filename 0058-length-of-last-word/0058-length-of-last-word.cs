public class Solution {
    public int LengthOfLastWord(string s) {
        int res = 0;

        for(int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ' && res != 0)
                break;

            if (s[i] == ' ')
                continue;

            res++;
        }

        return res;
    }
}
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        if(s.Length == 0)
            return 0;

        int res = 1;
        int l = 0;
        int r = 1;
        var letters = new HashSet<char>();
        var dict  = new Dictionary<int, char>();

        letters.Add(s[0]);
        dict.Add(0, s[0]);
        
        while (r < s.Length)
        {
            while (!letters.Add(s[r]))
            {
                letters.Remove(dict[l]);
                dict.Remove(l);
                l++;
            }
            dict.Add(r, s[r]);
            res = Math.Max(res, r - l + 1);
            r++;
        }
        return res;
    }
}
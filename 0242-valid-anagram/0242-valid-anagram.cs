public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> map = new Dictionary<char, int>();
        
        if(s.Length != t.Length)
            return false;

        for(int i = 0; i < t.Length; i++)
        {
            if(map.ContainsKey(s[i]))
                map[s[i]] += 1;
            else
                map[s[i]] = 1;

            if(map.ContainsKey(t[i]))
                map[t[i]] -= 1;
            else
                map[t[i]] = -1;
        }

        foreach (var value in map)
        {
            if (value.Value != 0)
                return false;
        }

        return true;
    }
}
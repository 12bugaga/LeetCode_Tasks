public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char, string> patternMap = new Dictionary<char, string>();
        Dictionary<string, char> sMap = new Dictionary<string, char>();
        int j = 0, i=0;
        string temp = "";

        while (i < pattern.Length)
        {

            while (j < s.Length && s[j] != ' ')
            {
                temp+=(s[j]);
                j++;
            }

            if ((patternMap.ContainsKey(pattern[i]) && patternMap[pattern[i]] != temp) || (sMap.ContainsKey(temp) && sMap[temp] != pattern[i]) || temp.Length == 0)
                return false;
            
            j++;
            patternMap[pattern[i]] = temp;
            sMap[temp] = pattern[i];
            temp = "";
            i++;
        }
        if(j < s.Length || i < pattern.Length)
            return false;
        return true;
    }
}
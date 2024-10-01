public class Solution {
    public bool IsIsomorphic(string s, string t) {
        char[] sMap=new char[128];
        char[] tMap = new char[128];

        for(int i = 0; i < s.Length; i++){
            
            if((sMap[s[i]]!='\0' && sMap[s[i]] != t[i]) || (tMap[t[i]] != '\0' && tMap[t[i]] != s[i])){
                return false;
            }

            sMap[s[i]]=t[i];
            tMap[t[i]]=s[i];
        }
        return true;
    }
}
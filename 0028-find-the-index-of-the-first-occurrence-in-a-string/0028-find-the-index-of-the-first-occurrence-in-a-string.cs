public class Solution {
    public int StrStr(string haystack, string needle) {
        int res = -1;
        
        if (needle.Length > haystack.Length)
            return res;

        for (int i = 0; i < haystack.Length; i++)
        {
            for(int j = 0; j < needle.Length; j++)
            {
                if (i + j >= haystack.Length)
                    return -1;
                    
                if (haystack[i+j] == needle[j] && j == 0)
                    res = i;

                if(haystack[i + j] != needle[j])
                {
                    res = -1; 
                    break;
                }

                if (j == needle.Length-1)
                    return res;
            }
        }
        
        return res;
    }
}
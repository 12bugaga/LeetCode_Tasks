public class Solution {
    public bool IsPalindrome(int x) {
        bool result = false;
        string xstr = x.ToString();
        string reverse = "";
        for(int i = xstr.Length - 1; i >= 0; i--)
        {
            reverse += xstr[i];
        }

        if(xstr == reverse) 
            result = true;

        return result;
    }
}
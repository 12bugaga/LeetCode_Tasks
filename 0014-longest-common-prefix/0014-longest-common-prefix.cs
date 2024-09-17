public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        var result = "";
        var prev = "";
        for(int i = 0; i < strs[0].Length; i++)
        {
            prev = result;
            result += ((strs[0])[i]).ToString();

            foreach(var str in strs){
                if (str.Length < result.Length) 
                    return prev.Substring(0, str.Length);
                if(str.Substring(0, result.Length) != result)
                    return prev;
            }
        }

        return result;
    }
}
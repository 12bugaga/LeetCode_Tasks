public class Solution {
    public int RomanToInt(string s) {
        int result = 0;
        var symbols = new Dictionary<string, int>
        {
            { "I", 1 },
            { "V", 5 },
            { "X", 10 },
            { "L", 50 },
            { "C", 100 },
            { "D", 500 },
            { "M", 1000 },
            { "IV", 4 },
            { "IX", 9 },
            { "XL", 40 },
            { "XC", 90 },
            { "CD", 400 },
            { "CM", 900 },
        };

        for(int i = 0; i < s.Length; i++)
        {
            if(s[i] == 'I' || s[i] == 'X' || s[i] == 'C')
            {
                if (i != s.Length - 1 && symbols.ContainsKey(s[i].ToString() + s[i + 1].ToString()))
                {
                        result += symbols[s[i].ToString() + s[i + 1].ToString()];
                    i++;
                }
                else result += symbols[s[i].ToString()];
            }
            else result += symbols[s[i].ToString()];
        }

        return result;
    }
}
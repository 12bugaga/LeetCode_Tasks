public class Solution {
    public bool IsValid(string s) {
        var st = new Stack<char>();
        st.Push(s[0]);

        var set = new HashSet<string>();
        set.Add("()");
        set.Add("[]");
        set.Add("{}");

        for (int i = 1; i < s.Length; i++)
        {
            var lastTwo = (st.Count() > 0 ? st.Peek().ToString() : "") + s[i];
            
            if(set.Contains(lastTwo))
                st.Pop();
            else
                st.Push(s[i]);
        }

        return st.Count() > 0 ? false : true;
    }
}
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (string s in strs)
            {
                string key = String.Concat(s.OrderBy(c => c));

                if (dict.ContainsKey(key))
                    dict[key].Add(s);
                else
                    dict[key] = new List<string> { s };
            }

            IList<IList<string>> result = new List<IList<string>>();
            foreach (List<string> val in dict.Values)
                result.Add(val);

            return result;
    }
}
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Count(); i++)
        {
            if (dict.ContainsKey(nums[i]))
                return true;
            dict[nums[i]] = 1;
        }
        return false;
    }
}
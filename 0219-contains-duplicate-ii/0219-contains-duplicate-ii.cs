public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        
        var dict = new Dictionary<int, int>();
        int indx = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(!dict.Keys.Contains(nums[i]))
            {
                dict.Add(nums[i], i);
                continue;
            }
            
            indx = dict[nums[i]];
            if(Math.Abs(indx - i) <= k)
                return true;

            dict[nums[i]] = i;
        }

        return false;
    }
}
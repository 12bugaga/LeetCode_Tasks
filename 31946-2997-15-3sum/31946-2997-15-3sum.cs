public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        
        Array.Sort(nums);
        var res = new List<IList<int>>();
        int target = 0;
        int len = nums.Length;
        int i = 0;

        while(i < len - 2)
        {
            target = 0 + nums[i];

            int l = i + 1;
            int r = nums.Length - 1;

            while(l < r)
            {
                if(target + nums[l] + nums[r] == 0)
                {
                    res.Add(new List<int> { nums[i], nums[l], nums[r] });
                    l++;
                    r--;

                    while(nums[l] == nums[l-1] && l < len - 2)
                        l++;
                    while(nums[r] == nums[r+1] && r > i)
                        r--;
                }
                else if(target + nums[l] + nums[r] > 0)
                    r--;
                else
                    l++;
            }

            i++;
            while(nums[i] == nums[i-1] && i < len - 2)
                i++;
        }

        return res;
    }
}
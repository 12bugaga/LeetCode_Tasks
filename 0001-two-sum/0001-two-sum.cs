public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = new int[2];
        for(int i = 0; i < nums.Count(); i++)
        {
            for(int j = i+1; j < nums.Count(); j++)
            {
                result[0]= i;
                result[1]= j;
                if(nums[result[0]] + nums[result[1]] == target) break;
            }
            if(nums[result[0]] + nums[result[1]] == target) break;
        }
        return result;
    }
}
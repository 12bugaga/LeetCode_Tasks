public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 1;
        
        for(int i = k; i < nums.Length; i++)
        {
            if(nums[i] == nums[k-1]) continue;

            nums[k] = nums[i];
            k++;
        }

        return k;
    }
}
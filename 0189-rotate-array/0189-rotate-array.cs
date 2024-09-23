public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        if(k == 0) return;
        int i, j;
        // Rotate right part
        for(i = nums.Length - k, j = nums.Length - 1; i < j; i++, j--)
            (nums[i], nums[j]) = (nums[j], nums[i]);
        
        // Rotate left part
        for(i = 0, j = nums.Length - k - 1; i < j; i++, j--)
            (nums[i], nums[j]) = (nums[j], nums[i]);

        //Right left and right part, relatively center
        for(i = 0, j = nums.Length - 1; i < j; i++, j--)
            (nums[i], nums[j]) = (nums[j], nums[i]);
    }
}
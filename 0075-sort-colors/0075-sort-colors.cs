public class Solution {
    public void SortColors(int[] nums) {
        
        var dict = new Dictionary<int, int>();
        dict.Add(0, 0);
        dict.Add(1, 0);
        dict.Add(2, 0);
        
        for(int i = 0; i < nums.Length; i++)
            dict[nums[i]] += 1;    

        for(int i = 0; i < nums.Length; i++)
        {
            if(dict[0] != 0)
            {
                nums[i] = 0;
                dict[0] -= 1;
            }
            else if (dict[1] != 0)
            {
                nums[i] = 1;
                dict[1] -= 1;
            }
            else
            {
                nums[i] = 2;
                dict[2] -= 1;
            }
        }
    }
}
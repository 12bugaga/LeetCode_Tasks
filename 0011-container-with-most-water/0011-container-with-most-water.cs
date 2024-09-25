public class Solution {
    public int MaxArea(int[] height) {
        int i = 0;
        int j = height.Length-1;
        int res = 0;

        while(i < j)
        {
            if(res < Math.Min(height[i], height[j]) * (j - i))
                res = Math.Min(height[i], height[j]) * (j - i);

            if(height[i] == height[j])
                i++;
            else if(height[i] < height[j])
                i++;
            else
                j--;
        }

        return res; 
    }
}
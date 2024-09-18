public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(n == 0) return;

        if(m == 0)
        {
            for(int k = 0; k < n; k++)
                nums1[k] = nums2[k];
            
            return;
        }
        
        int[] result = new int[m+n];
        int i = 0;
        int j = 0;
        for (int k = 0; k < n + m; k++)
        {
            result[k] = nums1[k];
            if (i < m && j < n)
            {
                if (result[i] > nums2[j])
                {
                    nums1[k] = nums2[j];
                    j++;
                }
                else
                {
                    nums1[k] = result[i];
                    i++;
                }
                continue;
            }

            if (i >= m && j < n)
            {
                nums1[k] = nums2[j];
                j++;
                continue;
            }

            if (i < m && j >= n)
            {
                nums1[k] = result[i];
                i++;
                continue;
            }
        }
    }
}
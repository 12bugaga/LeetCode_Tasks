public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l = matrix[0].Length -1;
        int h = 0;

        while(l >= 0 && h < matrix.Length)
        {
            if (matrix[h][l] == target)
                return true;

            if (matrix[h][l] > target)
                l -= 1;
            else
                h += 1;
        }

        return false;
    }
}
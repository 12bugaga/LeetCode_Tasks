public class Solution {
    public void SetZeroes(int[][] matrix) {
        
        HashSet<int> row = new HashSet<int>();
        HashSet<int> col = new HashSet<int>();

        for (int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[0].Length; j++)
            {
                if (matrix[i][j] == 0)
                {
                    row.Add(i);
                    col.Add(j);
                }
            }
        }

        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[0].Length; j++)
            {
                if (row.Contains(i) || col.Contains(j))
                    matrix[i][j] = 0;
            }
        }
    }
}
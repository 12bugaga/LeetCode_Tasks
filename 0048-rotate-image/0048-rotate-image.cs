public class Solution {
    public void Rotate(int[][] matrix) {
        int rowCount = matrix.Length;
        int colCount = matrix[0].Length;

        // Transposition
        int temp = 0;
        for(int i = 0; i < rowCount; i++)
        {
            for(int j = i; j < colCount; j++)
            {
                temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        // Change column
        for(int i = 0; i < colCount / 2; i++)
        {
            for(int j = 0; j < rowCount; j++)
            {
                temp = matrix[j][i];
                matrix[j][i] = matrix[j][colCount - i - 1];
                matrix[j][colCount - i - 1] = temp;
            }
        }
    }
}
public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char> hor = new HashSet<char>();
        HashSet<char>[] ver = new HashSet<char>[9];
        for(int i = 0; i < ver.Length; i++)
            ver[i] = new HashSet<char>();

        HashSet<char>[][] set = new HashSet<char>[3][];
        for (int i = 0; i < set.Length; i++)
        {
            set[i] = new HashSet<char>[3];
            for (int j = 0; j < set.LongLength; j++)
                set[i][j] = new HashSet<char>();
        }

        for(int i = 0; i < board.Length; i++)
        {
            hor = new HashSet<char>();
            for(int j = 0; j < board[0].Length; j++)
            {
                if (board[i][j] == '.')
                    continue;

                // Check by horizontal
                if (hor.Contains(board[i][j]))
                    return false;
                else
                    hor.Add(board[i][j]);

                // Check vertical
                if (ver[j].Contains(board[i][j]))
                    return false;
                else
                    ver[j].Add(board[i][j]);

                // Check board 3x3
                if (set[i / 3][j / 3].Contains(board[i][j]))
                    return false;
                else
                    set[i / 3][j / 3].Add(board[i][j]);
            }
        }

        return true;
    }
}
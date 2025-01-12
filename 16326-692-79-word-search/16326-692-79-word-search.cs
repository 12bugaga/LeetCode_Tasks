public class Solution {

    public bool Exist(char[][] board, string word) {
        
        bool[][] blocks = new bool[board.Length][];
        for(int i = 0; i < board.Length; i++)
            blocks[i] = new bool[board[0].Length];

        for (int i = 0; i < board.Length; i++)
            for (int j = 0; j < board[0].Length; j++)
            {
                if (Dfs(board, word, i, j, 0, blocks))
                    return true;
            }

        return false;
    }

    public bool Dfs(char[][] board, string word, int r, int c, int index, bool[][] blocks)
    {
        if (index == word.Length)
            return true;

        if (r < 0|| r >= board.Length || c < 0 || c >= board[0].Length || blocks[r][c] || index > word.Length || board[r][c] != word[index])
            return false;

        blocks[r][c] = true;
        var exist =
            Dfs(board, word, r, c + 1, index + 1, blocks) ||
            Dfs(board, word, r, c - 1, index + 1, blocks) ||
            Dfs(board, word, r + 1, c, index + 1, blocks) ||
            Dfs(board, word, r - 1, c, index + 1, blocks);
        blocks[r][c] = false;

        return exist;
    }
}
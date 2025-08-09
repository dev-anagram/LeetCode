public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // rows
        string digits = "0123456789";
        HashSet<int> set = new HashSet<int>();
        for(int y = 0; y < board.Length; y++){
            for(int x = 0; x < board[0].Length; x++){
                if(digits.Contains(board[y][x]))
                    if(!set.Contains(board[y][x])){
                        set.Add(board[y][x]);
                    }else{
                        return false;
                    }
            }
            set.Clear();
        }
        // cols
        for(int x = 0; x < board[0].Length; x++){
            for(int y = 0; y < board.Length; y++){
                if(digits.Contains(board[y][x]))
                    if(!set.Contains(board[y][x])){
                        set.Add(board[y][x]);
                    }else{
                        return false;
                    }
            }
            set.Clear();
        }
        // 3x3 cells
        int[,] cells = {
            {0, 0},{0, 3},{0, 6},
            {3, 0},{3, 3},{3, 6},
            {6, 0},{6, 3},{6, 6}
        };

        for(int i = 0; i < cells.GetLength(0); i++){
            int cellY = cells[i, 0];
            int cellX = cells[i, 1];

            for(int y = cellY; y < cellY + 3; y++){
                for(int x = cellX; x < cellX + 3; x++){
                    if(digits.Contains(board[y][x]))
                        if(!set.Contains(board[y][x])){
                            set.Add(board[y][x]);
                        }else{
                            return false;
                        }
                }
            }
            set.Clear();
        }

        return true;
    }
}

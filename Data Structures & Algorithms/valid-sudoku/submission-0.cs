public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        var seen = new HashSet<string>();

        for(int i =0 ; i<board.Length ; i++){
            for(int j =0 ; j<board[i].Length ; j++){
                if(board[i][j] !='.')
                {

                    string row = $"{board[i][j]} at row {i}";
                    string col = $"{board[i][j]} at column {j}";
                    string box = $"{board[i][j]} at box {i/3} {j/3}";

                    if(!seen.Add(row) || !seen.Add(col) || !seen.Add(box))
                        return false  ;
                    }

                }
        }
        
        return true ;
    }
}

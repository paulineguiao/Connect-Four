public class Model
{
    private const int Rows = 6;
    private const int Columns = 7;
    private char[,] board;

    public Model()
    {
        board = new char[Rows, Columns];
        ResetBoard();
    }

    public void ResetBoard()
    {
        for (int r = 0; r < Rows; r++)
            for (int c = 0; c < Columns; c++)
                board[r, c] = ' ';
    }

    public char[,] GetGrid() => board;

    public bool IsColumnFull(int column)
    {
        return board[0, column] != ' ';
    }

    public int DropPiece(int column, char symbol)
    {
        for (int r = Rows - 1; r >= 0; r--)
        {
            if (board[r, column] == ' ')
            {
                board[r, column] = symbol;
                return r;
            }
        }
        return -1;
    }

    public bool CheckWin(int row, int column)
    {
        return CheckDirection(row, column, 0, 1) ||
               CheckDirection(row, column, 1, 0) ||  
               CheckDirection(row, column, 1, 1) || 
               CheckDirection(row, column, 1, -1);  
    }

    private bool CheckDirection(int row, int column, int rowMove, int colMove)
    {
        char symbol = board[row, column];
        int count = 1;

        
        int r = row + rowMove;
        int c = column + colMove;
        while (r >= 0 && r < Rows && c >= 0 && c < Columns && board[r, c] == symbol)
        {
            count++; r += rowMove; c += colMove;
        }

       
        r = row - rowMove;
        c = column - colMove;
        while (r >= 0 && r < Rows && c >= 0 && c < Columns && board[r, c] == symbol)
        {
            count++; r -= rowMove; c -= colMove;
        }

        return count >= 4;
    }
}
